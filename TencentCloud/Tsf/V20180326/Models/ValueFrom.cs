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

    public class ValueFrom : AbstractModel
    {
        
        /// <summary>
        /// k8s env 的 FieldRef
        /// </summary>
        [JsonProperty("FieldRef")]
        public FieldRef FieldRef{ get; set; }

        /// <summary>
        /// k8s env 的 ResourceFieldRef
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceFieldRef")]
        public ResourceFieldRef ResourceFieldRef{ get; set; }

        /// <summary>
        /// k8s env的configMapKeyRef
        /// </summary>
        [JsonProperty("ConfigMapKeyRef")]
        public CommonRef ConfigMapKeyRef{ get; set; }

        /// <summary>
        /// k8s env 的 secretKeyRef
        /// </summary>
        [JsonProperty("SecretKeyRef")]
        public CommonRef SecretKeyRef{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "FieldRef.", this.FieldRef);
            this.SetParamObj(map, prefix + "ResourceFieldRef.", this.ResourceFieldRef);
            this.SetParamObj(map, prefix + "ConfigMapKeyRef.", this.ConfigMapKeyRef);
            this.SetParamObj(map, prefix + "SecretKeyRef.", this.SecretKeyRef);
        }
    }
}

