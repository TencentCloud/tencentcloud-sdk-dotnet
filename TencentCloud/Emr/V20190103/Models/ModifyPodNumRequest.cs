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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPodNumRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群Id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 服务编号
        /// </summary>
        [JsonProperty("ServiceGroup")]
        public long? ServiceGroup{ get; set; }

        /// <summary>
        /// 角色编号
        /// </summary>
        [JsonProperty("ServiceType")]
        public long? ServiceType{ get; set; }

        /// <summary>
        /// 期望Pod数量
        /// </summary>
        [JsonProperty("PodNum")]
        public long? PodNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ServiceGroup", this.ServiceGroup);
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamSimple(map, prefix + "PodNum", this.PodNum);
        }
    }
}

