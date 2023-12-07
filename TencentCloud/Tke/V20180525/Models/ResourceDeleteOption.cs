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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceDeleteOption : AbstractModel
    {
        
        /// <summary>
        /// 资源类型，例如CBS、CLB、CVM
        /// </summary>
        [JsonProperty("ResourceType")]
        public string ResourceType{ get; set; }

        /// <summary>
        /// 集群删除时CBS资源的删除模式：terminate（销毁），retain （保留）。其他资源默认为销毁。
        /// </summary>
        [JsonProperty("DeleteMode")]
        public string DeleteMode{ get; set; }

        /// <summary>
        /// 是否跳过开启删除保护的资源，默认false，设置为true时不清理开启了删除保护的资源，clb有终端节点的情况也属于开了删除保护。
        /// </summary>
        [JsonProperty("SkipDeletionProtection")]
        public bool? SkipDeletionProtection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceType", this.ResourceType);
            this.SetParamSimple(map, prefix + "DeleteMode", this.DeleteMode);
            this.SetParamSimple(map, prefix + "SkipDeletionProtection", this.SkipDeletionProtection);
        }
    }
}

