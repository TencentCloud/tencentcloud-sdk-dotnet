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

namespace TencentCloud.Tds.V20220801.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFraudPremiumResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>App版本信息</p>
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// <p>品牌</p>
        /// </summary>
        [JsonProperty("Brand")]
        public string Brand{ get; set; }

        /// <summary>
        /// <p>客户端IP</p>
        /// </summary>
        [JsonProperty("ClientIp")]
        public string ClientIp{ get; set; }

        /// <summary>
        /// <p>机型</p>
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// <p>网络类型</p>
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// <p>应用包名</p>
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// <p>平台（2-Android，3-iOS，4-H5，5-微信小程序）</p>
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }

        /// <summary>
        /// <p>系统版本</p>
        /// </summary>
        [JsonProperty("SystemVersion")]
        public string SystemVersion{ get; set; }

        /// <summary>
        /// <p>SDK版本号</p>
        /// </summary>
        [JsonProperty("SdkBuildNo")]
        public string SdkBuildNo{ get; set; }

        /// <summary>
        /// <p>实时风险信息</p>
        /// </summary>
        [JsonProperty("RiskInfos")]
        public RiskInfo[] RiskInfos{ get; set; }

        /// <summary>
        /// <p>离线风险信息</p>
        /// </summary>
        [JsonProperty("HistRiskInfos")]
        public RiskInfo[] HistRiskInfos{ get; set; }

        /// <summary>
        /// <p>设备匿名标识</p>
        /// </summary>
        [JsonProperty("Openid")]
        public string Openid{ get; set; }

        /// <summary>
        /// <p>检测时间戳（毫秒）</p>
        /// </summary>
        [JsonProperty("RiskCheckTimestamp")]
        public string RiskCheckTimestamp{ get; set; }

        /// <summary>
        /// <p>额外信息</p>
        /// </summary>
        [JsonProperty("ExtraInfos")]
        public ExtraInfo[] ExtraInfos{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "Brand", this.Brand);
            this.SetParamSimple(map, prefix + "ClientIp", this.ClientIp);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "SystemVersion", this.SystemVersion);
            this.SetParamSimple(map, prefix + "SdkBuildNo", this.SdkBuildNo);
            this.SetParamArrayObj(map, prefix + "RiskInfos.", this.RiskInfos);
            this.SetParamArrayObj(map, prefix + "HistRiskInfos.", this.HistRiskInfos);
            this.SetParamSimple(map, prefix + "Openid", this.Openid);
            this.SetParamSimple(map, prefix + "RiskCheckTimestamp", this.RiskCheckTimestamp);
            this.SetParamArrayObj(map, prefix + "ExtraInfos.", this.ExtraInfos);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

