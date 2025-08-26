using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADFGVX_cipher
{
    public partial class Form1 : Form
    {
        public enum Mode
        {
            ADFGX_EN,
            ADFGX_CZ,
            ADFGVX
        }
        private Mode mode = Mode.ADFGX_EN;
        
        private readonly Dictionary<int, string> Numbers = new  Dictionary<int, string>()
        {
            { 0, "XZEROX" },
            { 1, "XONEX" },
            { 2, "XTVOX" },
            { 3, "XTHREEX" },
            { 4, "XFOURX" },
            { 5, "XFIVEX" },
            { 6, "XSIXX" },
            { 7, "XSEVENX" },
            { 8, "XEIGHTX" },
            { 9, "XNINEX" }
        };
        
        private readonly char[,] englishTable =
        {
            { 'A', 'B', 'C', 'D', 'E' },
            { 'F', 'G', 'H', 'I', 'K' },
            { 'L', 'M', 'N', 'O', 'P' },
            { 'Q', 'R', 'S', 'T', 'U' },
            { 'V', 'W', 'X', 'Y', 'Z' }
        };
        
        private readonly char[,] czechTable =
        {
            { 'A', 'B', 'C', 'D', 'E' },
            { 'F', 'G', 'H', 'I', 'J' },
            { 'K', 'L', 'M', 'N', 'O' },
            { 'P', 'Q', 'R', 'S', 'T' },
            { 'U', 'V', 'X', 'Y', 'Z' }
        };
        
        private char[,] fullTable =
        {
            { 'A', 'B', 'C', 'D', 'E', 'F' },
            { 'G', 'H', 'I', 'J', 'K', 'L' },
            { 'M', 'N', 'O', 'P', 'Q', 'R' },
            { 'S', 'T', 'U', 'V', 'W', 'X' },
            { 'Y', 'Z', '0', '1', '2', '3' },
            { '4', '5', '6', '7', '8', '9' }
        };

        private string keyword;
        private string keywordFiltered;
        private char[] alphabet;
        private bool is_ADFGX;
        
        public Form1()
        {
            InitializeComponent();
            
            
            button_mode_ADFGX_EN.Enabled = false;
            label_language_current.Text = "Current mode: ADFGX (English)";
            mode = Mode.ADFGX_EN;
            is_ADFGX = true;
            
            textBox_text_input.Enabled = false;
            button_keyword_change.Enabled = false;
            button_text_encrypt.Enabled = false;
            button_text_decrypt.Enabled = false;
        }

        private void button_keyword_use_Click(object sender, EventArgs e)
        {
            keyword = textBox_keyword_input.Text;
            keywordFiltered = Keyword_Filter(keyword);
            label_keyword_filtered.Text = keywordFiltered;
            
            if (keywordFiltered == "")
            {
                MessageBox.Show("Please enter a valid keyword!");
                return;
            }
            
            char[] keywordTransposedArray = keywordFiltered.ToCharArray();

            for (int i = 0; i < keywordTransposedArray.Length - 1; i++)
            {
                for (int j = 0; j < keywordTransposedArray.Length - i - 1; j++)
                {
                    if (keywordTransposedArray[j] > keywordTransposedArray[j + 1])
                    {
                        (keywordTransposedArray[j], keywordTransposedArray[j + 1]) =
                            (keywordTransposedArray[j + 1], keywordTransposedArray[j]);
                    }
                }
            }
            
            label_keyword_sorted.Text = new string(keywordTransposedArray);
            
            
            textBox_keyword_input.Enabled = false;
            button_keyword_use.Enabled = false;
            
            button_keyword_change.Enabled = true;
            textBox_text_input.Enabled = true;
            button_text_encrypt.Enabled = true;
            button_text_decrypt.Enabled = true;
        }

        private void button_table_generate_Click(object sender, EventArgs e)
        {
            string alphabet_raw;
            int numbers_length;
            if (mode == Mode.ADFGX_EN)
            {
                alphabet_raw = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
                numbers_length = 25;
            }
            else if (mode == Mode.ADFGX_CZ)
            {
                
                alphabet_raw = "ABCDEFGHIJKLMNOPQRSTUVXYZ";
                numbers_length = 25;
            }
            else
            {
                alphabet_raw = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                numbers_length = 36;
            }
            
            int[] numbers = new int[numbers_length];
            for (int i = 0; i < numbers_length; i++) { numbers[i] = i; }
            Random randomNumbers = new Random();
            
            for (int i = numbers_length - 1; i > 0; i--)
            {
                int j = randomNumbers.Next(0, i + 1);
                (numbers[i], numbers[j]) = (numbers[j], numbers[i]);
            }
            
            char[] alphabetChars = alphabet_raw.ToCharArray();
            int alphabet_length;
            if (mode == Mode.ADFGX_EN || mode == Mode.ADFGX_CZ) { alphabet_length = 25; }
            else { alphabet_length = 36; }
            
            alphabet = new char[alphabet_length];
            
            for (int i = 0; i < alphabet_length; i++)
            {
                alphabet[i] = alphabetChars[numbers[i]];
            }
            
            Fill_DataGridView();
        }
        
        private void button_mode_ADFGX_EN_Click(object sender, EventArgs e)
        {
            dataGridView_table.Columns.Clear();
            dataGridView_table.Rows.Clear();
            alphabet = null;
            label_language_current.Text = "Current mode: ADFGX (English)";
            mode = Mode.ADFGX_EN;
            is_ADFGX = true;
            
            button_mode_ADFGX_EN.Enabled = false;
            button_mode_ADFGX_CZ.Enabled = true;
            button_mode_ADFGVX.Enabled = true;
            
            textBox_keyword_input.Enabled = true;
            button_keyword_use.Enabled = true;
            
            button_keyword_change.Enabled = false;
            textBox_text_input.Enabled = false;
            button_text_encrypt.Enabled = false;
            button_text_decrypt.Enabled = false;
        }

        private void button_mode_ADFGX_CZ_Click(object sender, EventArgs e)
        {
            dataGridView_table.Columns.Clear();
            dataGridView_table.Rows.Clear();
            alphabet = null;
            label_language_current.Text = "Current mode: ADFGX (Czech)";
            mode = Mode.ADFGX_CZ;
            is_ADFGX = true;
            
            button_mode_ADFGX_EN.Enabled = true;
            button_mode_ADFGX_CZ.Enabled = false;
            button_mode_ADFGVX.Enabled = true;
            
            textBox_keyword_input.Enabled = true;
            button_keyword_use.Enabled = true;
            
            button_keyword_change.Enabled = false;
            textBox_text_input.Enabled = false;
            button_text_encrypt.Enabled = false;
            button_text_decrypt.Enabled = false;
        }
        
        private void button_mode_ADFGVX_Click(object sender, EventArgs e)
        {
            dataGridView_table.Columns.Clear();
            dataGridView_table.Rows.Clear();
            alphabet = null;
            label_language_current.Text = "Current mode: ADFGVX";
            mode = Mode.ADFGVX;
            is_ADFGX = false;
            
            button_mode_ADFGX_EN.Enabled = true;
            button_mode_ADFGX_CZ.Enabled = true;
            button_mode_ADFGVX.Enabled = false;
            
            textBox_keyword_input.Enabled = true;
            button_keyword_use.Enabled = true;
            
            button_keyword_change.Enabled = false;
            textBox_text_input.Enabled = false;
            button_text_encrypt.Enabled = false;
            button_text_decrypt.Enabled = false;
        }

        private void button_keyword_change_Click(object sender, EventArgs e)
        {
            textBox_keyword_input.Enabled = true;
            button_keyword_use.Enabled = true;
            
            button_keyword_change.Enabled = false;
            textBox_text_input.Enabled = false;
            button_text_encrypt.Enabled = false;
            button_text_decrypt.Enabled = false;
        }
        
        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        string Keyword_Filter(string keyword)
        {
            string keywordNormalized = keyword.Normalize(NormalizationForm.FormD);
            string keywordUpper = keywordNormalized.ToUpper();
            string keywordFiltered = "";
            foreach (char character in keywordUpper)
            {
                if (is_ADFGX && character >= 65 && character <= 90){
                    if (character == 74 && mode == Mode.ADFGX_EN)
                    {
                        keywordFiltered += 'I';
                    }
                    else if (character == 87 && mode == Mode.ADFGX_CZ)
                    {
                        keywordFiltered += 'V';
                    }
                    else
                    {
                        keywordFiltered += character;
                    }
                }
                else if ((!is_ADFGX && character >= 65 && character <= 90) || (!is_ADFGX && character >= 48 && character <= 57))
                {
                    keywordFiltered += character;
                }
            }

            return keywordFiltered;
        }
        
        string String_Filter(string openText)
        {
            string normalizedText = openText.Normalize(NormalizationForm.FormD);

            string filteredText = "";

            foreach (char c in normalizedText)
            {
                if ((c == 'j' && mode == Mode.ADFGX_EN) || (c == 'J' && mode == Mode.ADFGX_EN))
                {
                    filteredText = filteredText + "I";
                }
                else if ((c == 'w' && mode == Mode.ADFGX_CZ) || (c == 'W' && mode == Mode.ADFGX_CZ))
                {
                    filteredText = filteredText + "V";
                }
                else if (Char.IsUpper(c))
                {
                    filteredText = filteredText + c;
                }
                else if (Char.IsLower(c))
                {
                    char new_c = Char.ToUpper(c);
                    filteredText = filteredText + new_c;
                }
                else if (c == ' ')
                {
                    filteredText = filteredText + "XSPACEX";
                }
                else if (char.IsDigit(c))
                {
                    filteredText += Numbers[(int)char.GetNumericValue(c)];
                }
            }
            
            return filteredText;
        }

        string String_Defilter(string textFiltered)
        {
            string openText = textFiltered;

            for (int i = 0; i < 10; i++)
            {
                openText = openText.Replace($"{Numbers[i]}", $"{Numbers.Keys.ElementAt(i)}");
            }
            
            openText = openText.Replace("XSPACEX", " ");
            
            return openText;
        }

        string Text_Encrypt(string openText)
        {
            // Applying ADFG(V)X indexes
            char[] index = new char[dataGridView_table.ColumnCount - 1];
            if (is_ADFGX)
            {
                index[0] = 'A';
                index[1] = 'D';
                index[2] = 'F';
                index[3] = 'G';
                index[4] = 'X';
            }
            else
            {
                index[0] = 'A';
                index[1] = 'D';
                index[2] = 'F';
                index[3] = 'G';
                index[4] = 'V';
                index[5] = 'X';
            }
            string textIndexed = "";

            foreach (char openTextChar in openText)
            {
                int counter = 0;
                int rowCount = 0;
                foreach (char alphabetChar in alphabet)
                {
                    if (counter % index.Length == 0 && counter > 0)
                    {
                        rowCount++;
                    }
                    if (openTextChar == alphabetChar)
                    {
                        textIndexed += index[rowCount];
                        textIndexed += index[Array.IndexOf(alphabet, alphabetChar) % index.Length];
                    }
                    else { counter++; }
                }
            }
            
            // Writing text to lines
            
            string keyword = Keyword_Filter(textBox_keyword_input.Text);
            int columnsAmount = keyword.Length;
            int linesAmount = (int)Math.Ceiling((double)textIndexed.Length / (double)columnsAmount);
            char[,] textArray = new char[linesAmount,columnsAmount];
            char[] textIndexedArray = textIndexed.ToCharArray();
            int counterArray = 0;
            
            for (int i = 0; i < linesAmount; i++)
            {
                for (int j = 0; j < columnsAmount; j++)
                {
                    if (counterArray >= textIndexedArray.Length)
                    {
                        textArray[i, j] = ' ';
                    }
                    else
                    {
                        textArray[i, j] = textIndexedArray[counterArray];
                        counterArray++;
                    }
                }
            }
            
            // Transposition
            char[] keywordTransposedArray = keyword.ToCharArray();
            char[,] textArrayTransposed = textArray;

            for (int i = 0; i < keywordTransposedArray.Length - 1; i++)
            {
                for (int j = 0; j < keywordTransposedArray.Length - i - 1; j++)
                {
                    if (keywordTransposedArray[j] > keywordTransposedArray[j + 1])
                    {
                        (keywordTransposedArray[j], keywordTransposedArray[j + 1]) =
                            (keywordTransposedArray[j + 1], keywordTransposedArray[j]);

                        for (int k = 0; k < linesAmount; k++)
                        {
                            (textArrayTransposed[k, j], textArrayTransposed[k, j + 1]) =
                                (textArrayTransposed[k, j + 1], textArrayTransposed[k, j]);
                        }
                        
                    }
                }
            }

            string textTransposed = "";
            for (int i = 0; i < columnsAmount; i++)
            {
                for (int j = 0; j < linesAmount; j++)
                {
                    textTransposed += textArrayTransposed[j, i];
                }
            }
            
            return textTransposed;
        }

        string Text_Decrypt(string textEncrypted)
        {
            string allowedCharacters;
            if (is_ADFGX) { allowedCharacters = "ADFGX"; }
            else { allowedCharacters = "ADFGVX"; }
            for (int i = 0; i < textEncrypted.Length; i++)
            {
                if (!allowedCharacters.Contains(textEncrypted[i]) || textEncrypted.Length % 2 != 0)
                {
                    MessageBox.Show("Wrong text to decrypt!");
                    return "";
                }
            }
            
            // Keyword transposition
            string keyword = Keyword_Filter(textBox_keyword_input.Text);
            char[] keywordArray = keyword.ToCharArray();
            int[] keywordIndexesForTransposition = new int[keyword.Length];
            for (int i = 0; i < keywordIndexesForTransposition.Length; i++)
            {
                keywordIndexesForTransposition[i] = i;
            }

            for (int i = 0; i < keywordArray.Length - 1; i++)
            {
                for (int j = 0; j < keywordArray.Length - i - 1; j++)
                {
                    if (keywordArray[j] > keywordArray[j + 1])
                    {
                        (keywordArray[j], keywordArray[j + 1]) = (keywordArray[j + 1], keywordArray[j]);
                        
                        (keywordIndexesForTransposition[j], keywordIndexesForTransposition[j + 1]) =
                            (keywordIndexesForTransposition[j + 1], keywordIndexesForTransposition[j]);
                    }
                }
            }
            
            // Writing text to lines
            int columnsAmount = keyword.Length;
            int linesAmount = (int)Math.Ceiling((double)textEncrypted.Length / (double)columnsAmount);
            char[,] textArrayTransposed = new char[linesAmount,columnsAmount];
            char[] textEncryptedArray = textEncrypted.ToCharArray();
            
            int counterArray = textEncryptedArray.Length - 1;
            int fullColumnsAmount = textEncryptedArray.Length % columnsAmount;
            if (fullColumnsAmount == 0) { fullColumnsAmount = columnsAmount; }

            for (int i = columnsAmount - 1; i >= 0; i--)
            {
                for (int j = linesAmount - 1; j >= 0 ; j--)
                {
                    if (keywordIndexesForTransposition[i] >= fullColumnsAmount && j == linesAmount - 1)
                    {
                        textArrayTransposed[j, i] = ' ';
                    }
                    else
                    {
                        textArrayTransposed[j, i] = textEncryptedArray[counterArray];
                        counterArray--;  
                    }
                }
            }
            
            int k = 0;
            int columnToWrite = keywordIndexesForTransposition[k];
            char[,] textArray = new char[linesAmount, columnsAmount];

            for (int i = 0; i < columnsAmount; i++)
            {
                for (int j = 0; j < linesAmount; j++)
                {
                    textArray[j, columnToWrite] = textArrayTransposed[j, i];
                }
                k++;
                if (k == columnsAmount) { break; }
                columnToWrite = keywordIndexesForTransposition[k];
            }
            
            // Text decryption

            char[] textIndexedArray = new char[linesAmount * columnsAmount];
            k = 0;
            for (int i = 0; i < linesAmount; i++)
            {
                for (int j = 0; j < columnsAmount; j++)
                {
                    textIndexedArray[k] += textArray[i, j];
                    k++;
                }
            }
            string textIndexed = new string(textIndexedArray);
            textIndexed = textIndexed.Replace(" ", "");
            
            char[] index = new char[dataGridView_table.ColumnCount - 1];
            if (is_ADFGX)
            {
                index[0] = 'A';
                index[1] = 'D';
                index[2] = 'F';
                index[3] = 'G';
                index[4] = 'X';
            }
            else
            {
                index[0] = 'A';
                index[1] = 'D';
                index[2] = 'F';
                index[3] = 'G';
                index[4] = 'V';
                index[5] = 'X';
            }

            int[] textIndexedNumbers = new int[textIndexed.Length];
            k = 0;

            for (int i = 0; i < textIndexed.Length; i++)
            {
                for (int j = 0; j < index.Length; j++)
                {
                    if (textIndexed[i] == index[j])
                    {
                        textIndexedNumbers[k] = j;
                        k++;
                    }
                }
            }
            
            string textDecrypted = "";
            for (int i = 0; i < textIndexedNumbers.Length; i = i + 2)
            {
                int x = textIndexedNumbers[i];
                int y = textIndexedNumbers[i + 1];
                textDecrypted += dataGridView_table.Rows[x].Cells[y+1].Value;
            }
            
            return textDecrypted;
        }
        
        private void Fill_DataGridView()
        {
            dataGridView_table.Rows.Clear();
            if (mode == Mode.ADFGX_EN || mode == Mode.ADFGX_CZ) { dataGridView_table.ColumnCount = 6; }
            else { dataGridView_table.ColumnCount = 7; }
            dataGridView_table.RowTemplate.Height = 20;
            dataGridView_table.RowHeadersWidth = 22;
            
            dataGridView_table.Columns[0].Name = "";
            dataGridView_table.Columns[1].Name = "A";
            dataGridView_table.Columns[2].Name = "D";
            dataGridView_table.Columns[3].Name = "F";
            dataGridView_table.Columns[4].Name = "G";
            if (mode == Mode.ADFGX_EN || mode == Mode.ADFGX_CZ)
            {
                dataGridView_table.Columns[5].Name = "X";
            }
            else
            {
                dataGridView_table.Columns[5].Name = "V";
                dataGridView_table.Columns[6].Name = "X";
            }
            
            foreach (DataGridViewColumn column in dataGridView_table.Columns)
            {
                column.Width = 20;
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            
            if (is_ADFGX)
            {
                List<string[]> rows = new List<string[] >
                {
                    new string[] { "A", alphabet[0].ToString(), alphabet[1].ToString(), alphabet[2].ToString(), alphabet[3].ToString(), alphabet[4].ToString() },
                    new string[] { "D", alphabet[5].ToString(), alphabet[6].ToString(), alphabet[7].ToString(), alphabet[8].ToString(), alphabet[9].ToString() },
                    new string[] { "F", alphabet[10].ToString(), alphabet[11].ToString(), alphabet[12].ToString(), alphabet[13].ToString(), alphabet[14].ToString() },
                    new string[] { "G", alphabet[15].ToString(), alphabet[16].ToString(), alphabet[17].ToString(), alphabet[18].ToString(), alphabet[19].ToString() },
                    new string[] { "X", alphabet[20].ToString(), alphabet[21].ToString(), alphabet[22].ToString(), alphabet[23].ToString(), alphabet[24].ToString() },
                };
                
                foreach (var rowArray in rows)
                {
                    dataGridView_table.Rows.Add(rowArray);
                }
            }
            else
            {
                List<string[]> rows = new List<string[] >
                {
                    new string[] { "A", alphabet[0].ToString(), alphabet[1].ToString(), alphabet[2].ToString(), alphabet[3].ToString(), alphabet[4].ToString(), alphabet[5].ToString() },
                    new string[] { "D", alphabet[6].ToString(), alphabet[7].ToString(), alphabet[8].ToString(), alphabet[9].ToString(), alphabet[10].ToString(), alphabet[11].ToString() },
                    new string[] { "F", alphabet[12].ToString(), alphabet[13].ToString(), alphabet[14].ToString(), alphabet[15].ToString(), alphabet[16].ToString(), alphabet[17].ToString() },
                    new string[] { "G", alphabet[18].ToString(), alphabet[19].ToString(), alphabet[20].ToString(), alphabet[21].ToString(), alphabet[22].ToString(), alphabet[23].ToString() },
                    new string[] { "V", alphabet[24].ToString(), alphabet[25].ToString(), alphabet[26].ToString(), alphabet[27].ToString(), alphabet[28].ToString(), alphabet[29].ToString() },
                    new string[] { "X", alphabet[30].ToString(), alphabet[31].ToString(), alphabet[32].ToString(), alphabet[33].ToString(), alphabet[34].ToString(), alphabet[35].ToString() }
                };
                
                foreach (var rowArray in rows)
                {
                    dataGridView_table.Rows.Add(rowArray);
                }
            }
            
            dataGridView_table.ColumnHeadersVisible = true;
            dataGridView_table.RowHeadersVisible = false;
            dataGridView_table.ScrollBars = ScrollBars.None;
            dataGridView_table.ReadOnly = true;
            dataGridView_table.Width = dataGridView_table.ColumnCount * 20;
            dataGridView_table.Height = dataGridView_table.RowCount * 20;
            dataGridView_table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_table.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView_table.Font, FontStyle.Bold);
            dataGridView_table.Columns[0].DefaultCellStyle.Font = new Font(dataGridView_table.Font, FontStyle.Bold);
            dataGridView_table.ClearSelection();
        }

        private void button_text_encrypt_Click(object sender, EventArgs e)
        {
            if (alphabet == null)
            {
                MessageBox.Show("Please generate new table!");
                return;
            }

            string keyword = Keyword_Filter(textBox_keyword_input.Text);
            string filteredText = String_Filter(textBox_text_input.Text);
            string encryptedText = Text_Encrypt(filteredText);
            encryptedText = encryptedText.Replace(" ", "");
            
            string encryptedTextDivided = "";
            for (int i = 0; i < encryptedText.Length; i++)
            {
                if (i % (keyword.Length) == 0 && i != 0)
                {
                    encryptedTextDivided += " ";
                    encryptedTextDivided += encryptedText[i];
                }
                else { encryptedTextDivided += encryptedText[i]; }
            }
            textBox_text_output.Text = encryptedTextDivided;
        }

        private void button_text_filter_Click(object sender, EventArgs e)
        {
            textBox_text_output.Text = String_Filter(textBox_text_input.Text);
        }

        private void button_text_decrypt_Click(object sender, EventArgs e)
        {
            if (alphabet == null)
            {
                MessageBox.Show("Please generate new table!");
                return;
            }
            string textEncrypted = textBox_text_input.Text.Replace(" ", "");
            string textDecrypted = Text_Decrypt(textEncrypted);
            string openText = String_Defilter(textDecrypted);

            textBox_text_output.Text = openText;
        }

        private void button_table_input_manual_Click(object sender, EventArgs e)
        {
            string tableKeywordFiltered = Keyword_Filter(textBox_table_input_manual.Text);
            string tableKeyword = "";

            foreach (char c in tableKeywordFiltered)
            {
                if (!tableKeyword.Contains(c))
                {
                    tableKeyword += c;
                }
            }
            
            char[,] table;
            if (mode == Mode.ADFGX_EN) { table = englishTable; }
            else if (mode == Mode.ADFGX_CZ) { table = czechTable; }
            else { table = fullTable; }

            foreach (char c in table)
            {
                if (!tableKeyword.Contains(c))
                {
                    tableKeyword += c;
                }
            }
            
            alphabet = tableKeyword.ToCharArray();
            Fill_DataGridView();
        }

        private void button_info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ADFG(V)X encrypt/decrypt machine." +
                            "\n\nTo encrypt your text:" +
                            "\n\t1. Choose mode (ADFGX_EN, ADFGX_CZ, ADFGVX)." +
                            "\n\t2. Enter your keyword." +
                            "\n\t3. Generate new transposition table randomly or using your \t\tentered word." +
                            "\n\t4. Enter your text in the left window and press \"Encrypt\" \t\tbutton." +
                            "\n\nTo decrypt your text:" +
                            "\n\t1. Choose mode (ADFGX_EN, ADFGX_CZ, ADFGVX)." +
                            "\n\t2. Enter your keyword." +
                            "\n\t3. Generate new transposition table using your entered word." +
                            "\n\t4. Enter your text in the right window and press \"Decrypt\" \t\tbutton.");
        }
    }
}