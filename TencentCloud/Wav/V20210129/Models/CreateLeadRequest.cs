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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLeadRequest : AbstractModel
    {
        
        /// <summary>
        /// 来源ID
        /// </summary>
        [JsonProperty("ChannelId")]
        public ulong? ChannelId{ get; set; }

        /// <summary>
        /// 来源名称
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 创建时间， 单位毫秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public ulong? CreateTime{ get; set; }

        /// <summary>
        /// 线索类型：1-400呼入，2-常规留资
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }

        /// <summary>
        /// 经销商id
        /// </summary>
        [JsonProperty("DealerId")]
        public ulong? DealerId{ get; set; }

        /// <summary>
        /// 品牌id
        /// </summary>
        [JsonProperty("BrandId")]
        public ulong? BrandId{ get; set; }

        /// <summary>
        /// 车系id
        /// </summary>
        [JsonProperty("SeriesId")]
        public ulong? SeriesId{ get; set; }

        /// <summary>
        /// 客户姓名
        /// </summary>
        [JsonProperty("CustomerName")]
        public string CustomerName{ get; set; }

        /// <summary>
        /// 客户手机号
        /// </summary>
        [JsonProperty("CustomerPhone")]
        public string CustomerPhone{ get; set; }

        /// <summary>
        /// 车型id
        /// </summary>
        [JsonProperty("ModelId")]
        public ulong? ModelId{ get; set; }

        /// <summary>
        /// 客户性别: 0-未知, 1-男, 2-女
        /// </summary>
        [JsonProperty("CustomerSex")]
        public long? CustomerSex{ get; set; }

        /// <summary>
        /// 销售姓名
        /// </summary>
        [JsonProperty("SalesName")]
        public string SalesName{ get; set; }

        /// <summary>
        /// 销售手机号
        /// </summary>
        [JsonProperty("SalesPhone")]
        public string SalesPhone{ get; set; }

        /// <summary>
        /// Cc坐席姓名
        /// </summary>
        [JsonProperty("CcName")]
        public string CcName{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelId", this.ChannelId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "DealerId", this.DealerId);
            this.SetParamSimple(map, prefix + "BrandId", this.BrandId);
            this.SetParamSimple(map, prefix + "SeriesId", this.SeriesId);
            this.SetParamSimple(map, prefix + "CustomerName", this.CustomerName);
            this.SetParamSimple(map, prefix + "CustomerPhone", this.CustomerPhone);
            this.SetParamSimple(map, prefix + "ModelId", this.ModelId);
            this.SetParamSimple(map, prefix + "CustomerSex", this.CustomerSex);
            this.SetParamSimple(map, prefix + "SalesName", this.SalesName);
            this.SetParamSimple(map, prefix + "SalesPhone", this.SalesPhone);
            this.SetParamSimple(map, prefix + "CcName", this.CcName);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

