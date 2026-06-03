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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("RegistryId")]
        public string RegistryId{ get; set; }

        /// <summary>
        /// <p>实例的规格,<br>基础版：basic<br>标准版：standard<br>高级版：premium</p>
        /// </summary>
        [JsonProperty("RegistryType")]
        public string RegistryType{ get; set; }

        /// <summary>
        /// <p>实例删除保护，false为关闭</p>
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// <p>实例是否开启多版本控制，false为关闭</p>
        /// </summary>
        [JsonProperty("EnableCosVersioning")]
        public bool? EnableCosVersioning{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegistryId", this.RegistryId);
            this.SetParamSimple(map, prefix + "RegistryType", this.RegistryType);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "EnableCosVersioning", this.EnableCosVersioning);
        }
    }
}

