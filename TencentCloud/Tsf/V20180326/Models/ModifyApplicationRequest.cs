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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyApplicationRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 应用备注
        /// </summary>
        [JsonProperty("ApplicationDesc")]
        public string ApplicationDesc{ get; set; }

        /// <summary>
        /// 应用备注名
        /// </summary>
        [JsonProperty("ApplicationRemarkName")]
        public string ApplicationRemarkName{ get; set; }

        /// <summary>
        /// 服务配置信息列表
        /// </summary>
        [JsonProperty("ServiceConfigList")]
        public ServiceConfig[] ServiceConfigList{ get; set; }

        /// <summary>
        /// 应用的微服务类型
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// 注册配置治理信息
        /// </summary>
        [JsonProperty("ServiceGovernanceConfig")]
        public ServiceGovernanceConfig ServiceGovernanceConfig{ get; set; }

        /// <summary>
        /// 应用开发框架
        /// </summary>
        [JsonProperty("FrameworkType")]
        public string FrameworkType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationDesc", this.ApplicationDesc);
            this.SetParamSimple(map, prefix + "ApplicationRemarkName", this.ApplicationRemarkName);
            this.SetParamArrayObj(map, prefix + "ServiceConfigList.", this.ServiceConfigList);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamObj(map, prefix + "ServiceGovernanceConfig.", this.ServiceGovernanceConfig);
            this.SetParamSimple(map, prefix + "FrameworkType", this.FrameworkType);
        }
    }
}

