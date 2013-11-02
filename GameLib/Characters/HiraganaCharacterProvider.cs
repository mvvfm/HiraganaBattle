﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameLib.Characters
{
    public class HiraganaCharacterProvider : ICharacterProvider
    {
        internal static Dictionary<string, string> characters = new Dictionary<string, string>()
        {
            {"あ", "a"},
            {"い", "i"},
            {"う", "u"},
            {"え", "e"},
            {"お", "o"},
            {"か", "ka"},
            {"き", "ki"},
            {"く", "ku"},
            {"け", "ke"},
            {"こ", "ko"},
            {"さ", "sa"},
            {"し", "shi"},
            {"す", "su"},
            {"せ", "se"},
            {"そ", "so"},
            {"た", "ta"},
            {"ち", "chi"},
            {"つ", "tsu"},
            {"て", "te"},
            {"と", "to"},
            {"な", "na"},
            {"に", "ni"},
            {"ぬ", "nu"},
            {"ね", "ne"},
            {"の", "no"},
            {"は", "ha"},
            {"ひ", "hi"},
            {"ふ", "fu"},
            {"へ", "he"},
            {"ほ", "ho"},
            {"ま", "ma"},
            {"み", "mi"},
            {"む", "mu"},
            {"め", "me"},
            {"も", "mo"},
            {"や", "ya"},
            {"ゆ", "yu"},
            {"よ", "yo"},
            {"ら", "ra"},
            {"り", "ri"},
            {"る", "ru"},
            {"れ", "re"},
            {"ろ", "ro"},
            {"わ", "wa"},
            {"ん", "n"},
            {"じ", "ji"},
            {"だ", "da"},
            {"が", "ga"},
            {"ぎ", "gi"},
            {"ぐ", "gu"},
            {"げ", "ge"},
            {"ご", "go"},
            {"ざ", "za"},
            {"ず", "zu"},
            {"ぜ", "ze"},
            {"ぞ", "zo"},
            {"で", "de"},
            {"ど","do" },
            {"ば", "ba"},
            {"び", "bi"},
            {"ぶ", "bu"},
            {"べ", "be"},
            {"ぼ", "bo"},
            {"ぱ", "pa"},
            {"ぴ","pi"},
            {"ぷ","pu"},
            {"ぺ", "pe"},
            {"ぽ", "po"}
       
        };

        //private static string[] words = { "ありません", "きねん", "これ", "それ", "くるま", "だれ", "たかい", "あかい", "わるい", "いい", "くろい", "ふろい", "むずい", "あくらい", "さむい", "おおきい", "ひくい", "あ", "お", "そ", "る", "ろ", "ら", "は", "ま", "め", "に", "ぬ", "ね", "な", "の", "わ", "ば", "ひ", "ほ", "うえ", "あいだ", "まえ", "となり", "おいしい", "あたらしい", "たのしい", "うるさい", "しずか", "はなす", "する", "くる", "ぺんり", "のみ" };

        private static string[] words = { "うえ",
            "した","みぎ","ひだり","なか","あいだ","まえ","よこ","となり","そば","うしろ","たかい","やすい","ひくい","おいしい","ふるい","あたらしい","むずかしい","やさしい","あつい","つめたい","さむい","あたたかい",
            "すずしい","いそがしい","ちいさい","おおきい","おもしろい","たのしい","あかい","くろい","きいろい","あおい","ちやいろい","うすい","かわいい","あぶない","いくない","わるい","うるさい",
            "しずか","にきやか","あんぜん","きけん","しんせつ","ゆうめい","ふべん","きれい","ひま","げんき","いく","たべる","はなす","かく","きく","かう","うる","みる","よむ","ありません","きねん",
            "これ","それ","くるま","だれ","いい","ふろい","むずい","あくらい","あ","お","そ","る","ろ","ら","は","ま","め","に","ぬ","ね","な","の","わ","ば","ひ","ほ","する","くる","ぺんり","のみ",
            "とし","あした","きのう","げつようび","にちようび","どようび","じかん","とけい","わらう","とおい","あたま",
        };
        
        //TODO: for testing only
        //private static string[] words = { "ああ", "おお", "たお", "くあ" };
        
        public string[] Words
        {
            get { return words; }
        }

        public string Character(string s)
        {
            return characters[s];
        }
    }
}
