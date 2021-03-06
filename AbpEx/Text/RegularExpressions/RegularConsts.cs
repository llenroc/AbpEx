﻿namespace Abp.Text.RegularExpressions
{
    public static class RegularConsts
    {
        public const string IntegerPattern = @"((\\+)\\d)?\\d*";

        public const string LetterOrNumberPattern = @"[a-zA-Z0-9_]";

        public const string UnicodeCharacterPattern = @"[\u4e00-\u9fa5]";

        public const string BlankLinePattern = @"\n\s*\r";

        public const string HtmlTagPattern = @"<(\S*?)[^>]*>.*?</\1>|<.*?/>";

        public const string BeginEndBlankPattern = @"^\s*|\s*$";

        public const string UrlPattern =
            @"((https|http|ftp|rtsp|mms)?://)?(([0-9a-z_!~*'().&=+$%-]+: )?[0-9a-z_!~*'().&=+$%-]+@)?(([0-9]{1,3}\.){3}[0-9]{1,3}|([0-9a-z_!~*'()-]+\.)*([0-9a-z][0-9a-z-]{0,61})?[0-9a-z]\.[a-z]{2,6})(:[0-9]{1,4})?((/?)|(/[0-9a-z_!~*'().;?:@&=+$,%#-]+)+/?)";

        public const string EmailPattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

        public const string AccountPattern = @"^[a-zA-Z][a-zA-Z0-9_]{4,15}$";

        public const string IpPattern =
            @"(((25[0-5]|2[0-4][0-9]|19[0-1]|19[3-9]|18[0-9]|17[0-1]|17[3-9]|1[0-6][0-9]|1[1-9]|[2-9][0-9]|[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9]))|(192\.(25[0-5]|2[0-4][0-9]|16[0-7]|169|1[0-5][0-9]|1[7-9][0-9]|[1-9][0-9]|[0-9]))|(172\.(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|1[0-5]|3[2-9]|[4-9][0-9]|[0-9])))\.(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])";

        public const string TimePattern = @"((20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)";

        public const string DatePattern =
            @"((^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(10|12|0?[13578])([-\/\._])(3[01]|[12][0-9]|0?[1-9])$)|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(11|0?[469])([-\/\._])(30|[12][0-9]|0?[1-9])$)|(^((1[8-9]\d{2})|([2-9]\d{3}))([-\/\._])(0?2)([-\/\._])(2[0-8]|1[0-9]|0?[1-9])$)|(^([2468][048]00)([-\/\._])(0?2)([-\/\._])(29)$)|(^([3579][26]00)([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][0][48])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][0][48])([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][2468][048])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][2468][048])([-\/\._])(0?2)([-\/\._])(29)$)|(^([1][89][13579][26])([-\/\._])(0?2)([-\/\._])(29)$)|(^([2-9][0-9][13579][26])([-\/\._])(0?2)([-\/\._])(29)$))";

        public const string DateTimePattern =
            @"(((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?2-(0?[1-9]|1\d|2[0-8]))|(((1[6-9]|[2-9]\d)(0[48]|[2468][048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-)) (20|21|22|23|[0-1]?\d):[0-5]?\d:[0-5]?\d)";

        public const string ChineseTelephonePattern = @"(\(\d{3,4}-)|\d{3.4}-)?\d{7,8}";

        public const string QqNoPattern = @"[1-9][0-9]{4,9}";
     
        public const string ChineseZipcodePattern = @"[1-9]\d{5}(?!\d)";

        public const string ChineseIdentityNoPattern = @"[1-9]\d{14}|[1-9]\d{17}";
 
        public const string Base64Pattern = @"[A-Za-z0-9\+\/\=]";
        
        public const string SafeSqlStrPattern = @"[-|;|,|\/|\(|\)|\[|\]|\}|\{|%|@|\*|!|\']";
    }
}
