string abc ="abcdefgh";
//номер цвета
int color= Convert.ToInt64(bitm.GetPixel(w, h).Name.Substring(3, 2), 16);
richTextBox1.AppendText( abc[color].ToString()); // берем символы не из ascii, а из строки в которой все символы с нужной шириной, а порядок букв или любой или в порядке плотности для получения темных участков, порядок в обратную сторону получится инверсия цветов.
// в этом примере будет  ошибка из за того что на входе 256 цветов а на выходе столько сколько букв в переменной abc