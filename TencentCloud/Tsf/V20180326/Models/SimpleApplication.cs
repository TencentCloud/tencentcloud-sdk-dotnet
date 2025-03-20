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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SimpleApplication : AbstractModel
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
        /// 应用类型
        /// </summary>
        [JsonProperty("ApplicationType")]
        public string ApplicationType{ get; set; }

        /// <summary>
        /// 应用微服务类型
        /// </summary>
        [JsonProperty("MicroserviceType")]
        public string MicroserviceType{ get; set; }

        /// <summary>
        /// ApplicationDesc
        /// </summary>
        [JsonProperty("ApplicationDesc")]
        public string ApplicationDesc{ get; set; }

        /// <summary>
        /// ProgLang
        /// </summary>
        [JsonProperty("ProgLang")]
        public string ProgLang{ get; set; }

        /// <summary>
        /// ApplicationResourceType
        /// </summary>
        [JsonProperty("ApplicationResourceType")]
        public string ApplicationResourceType{ get; set; }

        /// <summary>
        /// CreateTime
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// ApigatewayServiceId
        /// </summary>
        [JsonProperty("ApigatewayServiceId")]
        public string ApigatewayServiceId{ get; set; }

        /// <summary>
        /// ApplicationRuntimeType
        /// </summary>
        [JsonProperty("ApplicationRuntimeType")]
        public string ApplicationRuntimeType{ get; set; }

        /// <summary>
        /// Apm业务系统id
        /// </summary>
        [JsonProperty("AmpInstanceId")]
        public string AmpInstanceId{ get; set; }

        /// <summary>
        /// Apm业务系统Name
        /// </summary>
        [JsonProperty("ApmInstanceName")]
        public string ApmInstanceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamSimple(map, prefix + "MicroserviceType", this.MicroserviceType);
            this.SetParamSimple(map, prefix + "ApplicationDesc", this.ApplicationDesc);
            this.SetParamSimple(map, prefix + "ProgLang", this.ProgLang);
            this.SetParamSimple(map, prefix + "ApplicationResourceType", this.ApplicationResourceType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ApigatewayServiceId", this.ApigatewayServiceId);
            this.SetParamSimple(map, prefix + "ApplicationRuntimeType", this.ApplicationRuntimeType);
            this.SetParamSimple(map, prefix + "AmpInstanceId", this.AmpInstanceId);
            this.SetParamSimple(map, prefix + "ApmInstanceName", this.ApmInstanceName);
        }
    }
}

