/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Ctem.V20231128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DisplaySubDomain : AbstractModel
    {
        
        /// <summary>
        /// <p>主键ID</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>子域名</p>
        /// </summary>
        [JsonProperty("SubDomain")]
        public string SubDomain{ get; set; }

        /// <summary>
        /// <p>Ip</p>
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// <p>国家</p>
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// <p>省份</p>
        /// </summary>
        [JsonProperty("Province")]
        public string Province{ get; set; }

        /// <summary>
        /// <p>城市</p>
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// <p>互联网服务提供商</p>
        /// </summary>
        [JsonProperty("Isp")]
        public string Isp{ get; set; }

        /// <summary>
        /// <p>公共字段</p>
        /// </summary>
        [JsonProperty("DisplayToolCommon")]
        public DisplayToolCommon DisplayToolCommon{ get; set; }

        /// <summary>
        /// <p>是否为云资产：0-非云资产 1-是云资产</p>
        /// </summary>
        [JsonProperty("IsCloudAsset")]
        public long? IsCloudAsset{ get; set; }

        /// <summary>
        /// <p>云资产是否下线：-1-已下线 0-正常</p>
        /// </summary>
        [JsonProperty("CloudAssetStatus")]
        public long? CloudAssetStatus{ get; set; }

        /// <summary>
        /// <p>可用率（百分比）</p>
        /// </summary>
        [JsonProperty("AvailabilityRate")]
        public long? AvailabilityRate{ get; set; }

        /// <summary>
        /// <p>可用状态 1:异常 0:正常</p>
        /// </summary>
        [JsonProperty("AvailabilityState")]
        public long? AvailabilityState{ get; set; }

        /// <summary>
        /// <p>域名解析状态 1:异常 0:正常</p>
        /// </summary>
        [JsonProperty("AnalysisState")]
        public long? AnalysisState{ get; set; }

        /// <summary>
        /// <p>平均时延：单位ms</p>
        /// </summary>
        [JsonProperty("AverageDelay")]
        public long? AverageDelay{ get; set; }

        /// <summary>
        /// <p>丢包率（百分比）</p>
        /// </summary>
        [JsonProperty("LossRate")]
        public long? LossRate{ get; set; }

        /// <summary>
        /// <p>DNS解析类型</p><p>A、AAAA、MX、CNAME、NX</p>
        /// </summary>
        [JsonProperty("DnsType")]
        public string DnsType{ get; set; }

        /// <summary>
        /// <p>DNS解析值</p>
        /// </summary>
        [JsonProperty("DnsValue")]
        public string DnsValue{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "SubDomain", this.SubDomain);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Province", this.Province);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "Isp", this.Isp);
            this.SetParamObj(map, prefix + "DisplayToolCommon.", this.DisplayToolCommon);
            this.SetParamSimple(map, prefix + "IsCloudAsset", this.IsCloudAsset);
            this.SetParamSimple(map, prefix + "CloudAssetStatus", this.CloudAssetStatus);
            this.SetParamSimple(map, prefix + "AvailabilityRate", this.AvailabilityRate);
            this.SetParamSimple(map, prefix + "AvailabilityState", this.AvailabilityState);
            this.SetParamSimple(map, prefix + "AnalysisState", this.AnalysisState);
            this.SetParamSimple(map, prefix + "AverageDelay", this.AverageDelay);
            this.SetParamSimple(map, prefix + "LossRate", this.LossRate);
            this.SetParamSimple(map, prefix + "DnsType", this.DnsType);
            this.SetParamSimple(map, prefix + "DnsValue", this.DnsValue);
        }
    }
}

