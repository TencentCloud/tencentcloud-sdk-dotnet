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
        /// 关键词
        /// </summary>
        [JsonProperty("Keywords")]
        public string Keywords{ get; set; }

        /// <summary>
        /// 搜索关键字，开头
        /// </summary>
        [JsonProperty("DomainStart")]
        public bool? DomainStart{ get; set; }

        /// <summary>
        /// 搜索关键字结尾
        /// </summary>
        [JsonProperty("DomainEnd")]
        public bool? DomainEnd{ get; set; }

        /// <summary>
        /// 排序
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
        /// 页码
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页显示数
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 后缀
        /// </summary>
        [JsonProperty("Suffix")]
        public long?[] Suffix{ get; set; }

        /// <summary>
        /// 一级分类
        /// </summary>
        [JsonProperty("ClassOne")]
        public long? ClassOne{ get; set; }

        /// <summary>
        /// 二级分类
        /// </summary>
        [JsonProperty("ClassTwo")]
        public long?[] ClassTwo{ get; set; }

        /// <summary>
        /// 三级分类
        /// </summary>
        [JsonProperty("ClassThree")]
        public long?[] ClassThree{ get; set; }

        /// <summary>
        /// 四级分类
        /// </summary>
        [JsonProperty("ClassFour")]
        public long?[] ClassFour{ get; set; }

        /// <summary>
        /// 排除关键字，开头
        /// </summary>
        [JsonProperty("FilterStart")]
        public bool? FilterStart{ get; set; }

        /// <summary>
        /// 排除关键字，结尾
        /// </summary>
        [JsonProperty("FilterEnd")]
        public bool? FilterEnd{ get; set; }

        /// <summary>
        /// 排除关键字
        /// </summary>
        [JsonProperty("FilterWords")]
        public string FilterWords{ get; set; }

        /// <summary>
        /// 交易类型
        /// </summary>
        [JsonProperty("TransType")]
        public long? TransType{ get; set; }

        /// <summary>
        /// 搜索白金域名
        /// </summary>
        [JsonProperty("IsTop")]
        public bool? IsTop{ get; set; }

        /// <summary>
        /// 结束时间排序啊 desc:倒序 asc:正序
        /// </summary>
        [JsonProperty("EndTimeSort")]
        public string EndTimeSort{ get; set; }

        /// <summary>
        /// 结束时间
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

