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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployServicePodDetail : AbstractModel
    {
        
        /// <summary>
        /// pod Id
        /// </summary>
        [JsonProperty("PodId")]
        public string PodId{ get; set; }

        /// <summary>
        /// pod状态
        /// </summary>
        [JsonProperty("PodStatus")]
        public string[] PodStatus{ get; set; }

        /// <summary>
        /// pod版本
        /// </summary>
        [JsonProperty("PodVersion")]
        public string PodVersion{ get; set; }

        /// <summary>
        /// pod创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// pod所在可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// webshell地址
        /// </summary>
        [JsonProperty("Webshell")]
        public string Webshell{ get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PodId", this.PodId);
            this.SetParamArraySimple(map, prefix + "PodStatus.", this.PodStatus);
            this.SetParamSimple(map, prefix + "PodVersion", this.PodVersion);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Webshell", this.Webshell);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

