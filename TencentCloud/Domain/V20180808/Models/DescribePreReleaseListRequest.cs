/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribePreReleaseListRequest : AbstractModel
    {
        
        /// <summary>
        /// 单独使用Keywords：使用域名关键词进行搜索
        /// Keywords+DomainStart（true）：使用域名开头关键词进行搜索
        /// Keywords+DomainEnd（true）：使用域名结尾关键词进行搜索
        /// Keywords+DomainStart（true）+DomainEnd（true）：使用域名开头或结尾关键词进行搜索
        /// </summary>
        [JsonProperty("Keywords")]
        public string Keywords{ get; set; }

        /// <summary>
        /// 是否以域名开头关键词进行搜索
        /// true：是
        /// false：否
        /// </summary>
        [JsonProperty("DomainStart")]
        public bool? DomainStart{ get; set; }

        /// <summary>
        /// 是否以域名结尾关键词进行搜索
        /// true：是
        /// false：否
        /// </summary>
        [JsonProperty("DomainEnd")]
        public bool? DomainEnd{ get; set; }

        /// <summary>
        /// 不同排序规则：
        /// 1： 价格升序
        /// 2： 价格降序
        /// 3： 域名升序
        /// 4： 结束时间升序
        /// 5： 店铺推荐升序
        /// 6： 结束时间降序
        /// 15:  创建时间升序
        /// 其他：结束时间升序
        /// </summary>
        [JsonProperty("Sort")]
        public long? Sort{ get; set; }

        /// <summary>
        /// 起始价格
        /// </summary>
        [JsonProperty("PriceStart")]
        public float? PriceStart{ get; set; }

        /// <summary>
        /// 结束价格
        /// </summary>
        [JsonProperty("PriceEnd")]
        public float? PriceEnd{ get; set; }

        /// <summary>
        /// 起始域名长度
        /// </summary>
        [JsonProperty("LengthStart")]
        public long? LengthStart{ get; set; }

        /// <summary>
        /// 结束域名长度
        /// </summary>
        [JsonProperty("LengthEnd")]
        public long? LengthEnd{ get; set; }

        /// <summary>
        /// 页码（默认为1）
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页显示数（默认为20）
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 后缀
        /// 1="com"
        /// 2="net"
        /// 4="biz"
        /// 6="info"
        /// 7="co"
        /// 9="cn"
        /// 10="com.cn"
        /// 11="wang"
        /// 12="vip"
        /// 13="cc"
        /// 14="net.cn"
        /// 15="org.cn"
        /// 16="top"
        /// 17="asia"
        /// 18="tv"
        /// 19="club"
        /// 20="shop"
        /// 21 ="中国"
        /// 23="online"
        /// 24="xyz"
        /// 25="网店"
        /// 26="网址"
        /// 27="在线"
        /// 28="ltd"
        /// 29="fans"
        /// 30="ren"
        /// 31="icu"
        /// </summary>
        [JsonProperty("Suffix")]
        public long?[] Suffix{ get; set; }

        /// <summary>
        /// 一级分类
        /// 1:"纯数字"
        /// 2:"单数字"
        /// 3:"双数字"
        /// 4:"三数字"
        /// 5:"四数字"
        /// 6:"五数字"
        /// 7:"六数字"
        /// 9:"单字母"
        /// 10:"双字母"
        /// 11:"三字母"
        /// 12:"四字母"
        /// 13:"五字母"
        /// 14:"单拼"
        /// 15:"双拼"
        /// 16:"三拼"
        /// 17:"杂米"
        /// 18:"两杂"
        /// 19:"三杂"
        /// 20:"四杂"
        /// </summary>
        [JsonProperty("ClassOne")]
        public long? ClassOne{ get; set; }

        /// <summary>
        /// 二级分类
        /// 13:"0开或带4"
        /// 14:"非0开不带4"
        /// 15:"不带0,4"
        /// 0:"非全声母"
        /// 6:"全声母"
        /// 16:"不带0,4"
        /// 32:"全声母"
        /// 5010:"CVCV"
        /// </summary>
        [JsonProperty("ClassTwo")]
        public long?[] ClassTwo{ get; set; }

        /// <summary>
        /// 三级分类
        /// 111:"AAA"
        /// 401:"3A及以上"
        /// 402:"AA结尾"
        /// 1122:"AABB"
        /// 1123:"AABC"
        /// 1212:"ABAB"
        /// 1221:"ABBA"
        /// 1233:"ABCC"
        /// 501:"4A及以上"
        /// 502:"3A及以上"
        /// 503:"AAA开头"
        /// 504:"AAA结尾"
        /// 505:"AA开头"
        /// 506:"AA结尾"
        /// 507:"三顺子开头"
        /// 508:"三顺子结尾"
        /// 11223:"AABBC"
        /// 12233:"ABBCC"
        /// 601:"5A及以上"
        /// 602:"4A及以上"
        /// 603:"3A及以上"
        /// 604:"4A开头"
        /// 605:"4A结尾"
        /// 606:"AAA开头"
        /// 607:"AAA结尾"
        /// 608:"AA开头"
        /// 609:"AA结尾"
        /// 610:"ABAB开头"
        /// 611:"ABAB结尾"
        /// 612:"AABB开头"
        /// 613:"AABB结尾"
        /// 614:"四顺子开头"
        /// 615:"四顺子结尾"
        /// 616:"三顺子开头"
        /// 617:"三顺子结尾"
        /// 121212:"ABABAB"
        /// 112233:"AABBCC"
        /// 123123:"ABCABC"
        /// 211:"LNN"
        /// 221:"LLN"
        /// 121:"NLN"
        /// 212:"LNL"
        /// 122:"NLL"
        /// 1112:"NNNL"
        /// 2111:"LNNN"
        /// 1212:"NLNL"
        /// 2121:"LNLN"
        /// 1222:"NLLL"
        /// 2221:"LLLN"
        /// 1122:"NNLL"
        /// 2211:"LLNN"
        /// 31:"W结尾"
        /// 112:"AAB"
        /// 122:"ABB"
        /// 121:"ABA"
        /// 41:"W结尾"
        /// 1112:"AAAB"
        /// 1222:"ABBB"
        /// 1122:"AABB"
        /// 1212:"ABAB"
        /// </summary>
        [JsonProperty("ClassThree")]
        public long?[] ClassThree{ get; set; }

        /// <summary>
        /// 四级分类
        /// 1:"仅含2种数字"
        /// 1:"仅含2种数字"
        /// 2:"仅含3种数字"
        /// 4:"仅含1种字母"
        /// 8:"仅含1种数字"
        /// </summary>
        [JsonProperty("ClassFour")]
        public long?[] ClassFour{ get; set; }

        /// <summary>
        /// 是否以域名开头排除关键词进行搜索
        /// </summary>
        [JsonProperty("FilterStart")]
        public bool? FilterStart{ get; set; }

        /// <summary>
        /// 是否以域名结尾排除关键词进行搜索
        /// </summary>
        [JsonProperty("FilterEnd")]
        public bool? FilterEnd{ get; set; }

        /// <summary>
        /// 域名排除关键词
        /// 单独使用FilterWords：使用排除关键词进行搜索
        /// FilterWords+FilterStart（true）：使用域名开头排除关键词进行搜索
        /// FilterWords+FilterEnd（true）：使用域名结尾排除关键词进行搜索
        /// FilterWords+FilterStart（true）+FilterEnd（true）：使用域名开头或结尾排除关键词进行搜索
        /// </summary>
        [JsonProperty("FilterWords")]
        public string FilterWords{ get; set; }

        /// <summary>
        /// 交易类型（目前只支持10）
        /// 10: 预释放域名
        /// </summary>
        [JsonProperty("TransType")]
        public long? TransType{ get; set; }

        /// <summary>
        /// 是否搜索白金域名
        /// </summary>
        [JsonProperty("IsTop")]
        public bool? IsTop{ get; set; }

        /// <summary>
        /// 结束时间排序 desc:倒序 asc:正序
        /// </summary>
        [JsonProperty("EndTimeSort")]
        public string EndTimeSort{ get; set; }

        /// <summary>
        /// 结束时间（YYYY-MM-DD）
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Keywords", this.Keywords);
            this.SetParamSimple(map, prefix + "DomainStart", this.DomainStart);
            this.SetParamSimple(map, prefix + "DomainEnd", this.DomainEnd);
            this.SetParamSimple(map, prefix + "Sort", this.Sort);
            this.SetParamSimple(map, prefix + "PriceStart", this.PriceStart);
            this.SetParamSimple(map, prefix + "PriceEnd", this.PriceEnd);
            this.SetParamSimple(map, prefix + "LengthStart", this.LengthStart);
            this.SetParamSimple(map, prefix + "LengthEnd", this.LengthEnd);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamArraySimple(map, prefix + "Suffix.", this.Suffix);
            this.SetParamSimple(map, prefix + "ClassOne", this.ClassOne);
            this.SetParamArraySimple(map, prefix + "ClassTwo.", this.ClassTwo);
            this.SetParamArraySimple(map, prefix + "ClassThree.", this.ClassThree);
            this.SetParamArraySimple(map, prefix + "ClassFour.", this.ClassFour);
            this.SetParamSimple(map, prefix + "FilterStart", this.FilterStart);
            this.SetParamSimple(map, prefix + "FilterEnd", this.FilterEnd);
            this.SetParamSimple(map, prefix + "FilterWords", this.FilterWords);
            this.SetParamSimple(map, prefix + "TransType", this.TransType);
            this.SetParamSimple(map, prefix + "IsTop", this.IsTop);
            this.SetParamSimple(map, prefix + "EndTimeSort", this.EndTimeSort);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}

