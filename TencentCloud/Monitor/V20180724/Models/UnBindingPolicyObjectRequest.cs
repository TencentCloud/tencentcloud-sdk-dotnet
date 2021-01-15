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

namespace TencentCloud.Monitor.V20180724.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnBindingPolicyObjectRequest : AbstractModel
    {
        
        /// <summary>
        /// 固定值，为"monitor"
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 策略组id，如传入PolicyId则该字段可传入任意值
        /// </summary>
        [JsonProperty("GroupId")]
        public long? GroupId{ get; set; }

        /// <summary>
        /// 待删除对象实例的唯一id列表，UniqueId从调用[获取已绑定对象列表接口](https://cloud.tencent.com/document/api/248/40570)的出参的List中得到
        /// </summary>
        [JsonProperty("UniqueId")]
        public string[] UniqueId{ get; set; }

        /// <summary>
        /// 实例分组id, 如果按实例分组删除的话UniqueId参数是无效的
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public long? InstanceGroupId{ get; set; }

        /// <summary>
        /// 告警策略ID，使用此字段时GroupId可传入任意值
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "UniqueId.", this.UniqueId);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
        }
    }
}

