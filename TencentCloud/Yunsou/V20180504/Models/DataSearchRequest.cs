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

namespace TencentCloud.Yunsou.V20180504.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataSearchRequest : AbstractModel
    {
        
        /// <summary>
        /// 云搜的业务ID，用以表明当前数据请求的业务
        /// </summary>
        [JsonProperty("ResourceId")]
        public ulong? ResourceId{ get; set; }

        /// <summary>
        /// 检索串
        /// </summary>
        [JsonProperty("SearchQuery")]
        public string SearchQuery{ get; set; }

        /// <summary>
        /// 当前页，从第0页开始计算
        /// </summary>
        [JsonProperty("PageId")]
        public ulong? PageId{ get; set; }

        /// <summary>
        /// 每页结果数
        /// </summary>
        [JsonProperty("NumPerPage")]
        public ulong? NumPerPage{ get; set; }

        /// <summary>
        /// 当前检索号，用于定位问题，建议指定并且全局唯一
        /// </summary>
        [JsonProperty("SearchId")]
        public string SearchId{ get; set; }

        /// <summary>
        /// 请求编码，0表示utf8，1表示gbk，建议指定
        /// </summary>
        [JsonProperty("QueryEncode")]
        public ulong? QueryEncode{ get; set; }

        /// <summary>
        /// 排序类型
        /// </summary>
        [JsonProperty("RankType")]
        public ulong? RankType{ get; set; }

        /// <summary>
        /// 数值过滤，结果中按属性过滤
        /// </summary>
        [JsonProperty("NumFilter")]
        public string NumFilter{ get; set; }

        /// <summary>
        /// 分类过滤，导航类检索请求
        /// </summary>
        [JsonProperty("ClFilter")]
        public string ClFilter{ get; set; }

        /// <summary>
        /// 检索用户相关字段
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

        /// <summary>
        /// 检索来源
        /// </summary>
        [JsonProperty("SourceId")]
        public ulong? SourceId{ get; set; }

        /// <summary>
        /// 是否进行二次检索，0关闭，1打开
        /// </summary>
        [JsonProperty("SecondSearch")]
        public ulong? SecondSearch{ get; set; }

        /// <summary>
        /// 指定返回最大篇数，无特殊原因不建议指定
        /// </summary>
        [JsonProperty("MaxDocReturn")]
        public ulong? MaxDocReturn{ get; set; }

        /// <summary>
        /// 是否smartbox检索，0关闭，1打开
        /// </summary>
        [JsonProperty("IsSmartbox")]
        public ulong? IsSmartbox{ get; set; }

        /// <summary>
        /// 是否打开高红标亮，0关闭，1打开
        /// </summary>
        [JsonProperty("EnableAbsHighlight")]
        public ulong? EnableAbsHighlight{ get; set; }

        /// <summary>
        /// 指定访问QC纠错业务ID
        /// </summary>
        [JsonProperty("QcBid")]
        public ulong? QcBid{ get; set; }

        /// <summary>
        /// 按指定字段进行group by，只能对数值字段进行操作
        /// </summary>
        [JsonProperty("GroupBy")]
        public string GroupBy{ get; set; }

        /// <summary>
        /// 按指定字段进行distinct，只能对数值字段进行操作
        /// </summary>
        [JsonProperty("Distinct")]
        public string Distinct{ get; set; }

        /// <summary>
        /// 高级排序参数，具体参见高级排序说明
        /// </summary>
        [JsonProperty("L4RankExpression")]
        public string L4RankExpression{ get; set; }

        /// <summary>
        /// 高级排序参数，具体参见高级排序说明
        /// </summary>
        [JsonProperty("MatchValue")]
        public string MatchValue{ get; set; }

        /// <summary>
        /// 经度信息
        /// </summary>
        [JsonProperty("Longitude")]
        public float? Longitude{ get; set; }

        /// <summary>
        /// 纬度信息
        /// </summary>
        [JsonProperty("Latitude")]
        public float? Latitude{ get; set; }

        /// <summary>
        /// 分类过滤并集
        /// </summary>
        [JsonProperty("MultiFilter")]
        public string[] MultiFilter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "SearchQuery", this.SearchQuery);
            this.SetParamSimple(map, prefix + "PageId", this.PageId);
            this.SetParamSimple(map, prefix + "NumPerPage", this.NumPerPage);
            this.SetParamSimple(map, prefix + "SearchId", this.SearchId);
            this.SetParamSimple(map, prefix + "QueryEncode", this.QueryEncode);
            this.SetParamSimple(map, prefix + "RankType", this.RankType);
            this.SetParamSimple(map, prefix + "NumFilter", this.NumFilter);
            this.SetParamSimple(map, prefix + "ClFilter", this.ClFilter);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "SourceId", this.SourceId);
            this.SetParamSimple(map, prefix + "SecondSearch", this.SecondSearch);
            this.SetParamSimple(map, prefix + "MaxDocReturn", this.MaxDocReturn);
            this.SetParamSimple(map, prefix + "IsSmartbox", this.IsSmartbox);
            this.SetParamSimple(map, prefix + "EnableAbsHighlight", this.EnableAbsHighlight);
            this.SetParamSimple(map, prefix + "QcBid", this.QcBid);
            this.SetParamSimple(map, prefix + "GroupBy", this.GroupBy);
            this.SetParamSimple(map, prefix + "Distinct", this.Distinct);
            this.SetParamSimple(map, prefix + "L4RankExpression", this.L4RankExpression);
            this.SetParamSimple(map, prefix + "MatchValue", this.MatchValue);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamArraySimple(map, prefix + "MultiFilter.", this.MultiFilter);
        }
    }
}

