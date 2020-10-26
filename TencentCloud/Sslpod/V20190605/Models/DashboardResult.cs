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

namespace TencentCloud.Sslpod.V20190605.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DashboardResult : AbstractModel
    {
        
        /// <summary>
        /// 安全等级图表
        /// </summary>
        [JsonProperty("SecurityLevelPie")]
        public ChartNameValue[] SecurityLevelPie{ get; set; }

        /// <summary>
        /// 证书品牌图表
        /// </summary>
        [JsonProperty("CertBrandsPie")]
        public ChartNameValue[] CertBrandsPie{ get; set; }

        /// <summary>
        /// 证书有效时间图表
        /// </summary>
        [JsonProperty("CertValidTimePie")]
        public ChartNameValue[] CertValidTimePie{ get; set; }

        /// <summary>
        /// 证书类型图表
        /// </summary>
        [JsonProperty("CertTypePie")]
        public ChartNameValue[] CertTypePie{ get; set; }

        /// <summary>
        /// ssl bugs图表
        /// </summary>
        [JsonProperty("SSLBugsLoopholeHistogram")]
        public ChartHistogram[] SSLBugsLoopholeHistogram{ get; set; }

        /// <summary>
        /// 合规图表
        /// </summary>
        [JsonProperty("ComplianceHistogram")]
        public ChartHistogram[] ComplianceHistogram{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SecurityLevelPie.", this.SecurityLevelPie);
            this.SetParamArrayObj(map, prefix + "CertBrandsPie.", this.CertBrandsPie);
            this.SetParamArrayObj(map, prefix + "CertValidTimePie.", this.CertValidTimePie);
            this.SetParamArrayObj(map, prefix + "CertTypePie.", this.CertTypePie);
            this.SetParamArrayObj(map, prefix + "SSLBugsLoopholeHistogram.", this.SSLBugsLoopholeHistogram);
            this.SetParamArrayObj(map, prefix + "ComplianceHistogram.", this.ComplianceHistogram);
        }
    }
}

