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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AssetWebLocationPath : AbstractModel
    {
        
        /// <summary>
        /// 虚拟路径
        /// </summary>
        [JsonProperty("VirtualPath")]
        public string VirtualPath{ get; set; }

        /// <summary>
        /// 物理路径
        /// </summary>
        [JsonProperty("RealPath")]
        public string RealPath{ get; set; }

        /// <summary>
        /// 文件所有者
        /// </summary>
        [JsonProperty("User")]
        public string User{ get; set; }

        /// <summary>
        /// 文件所属组
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 文件权限
        /// </summary>
        [JsonProperty("Permission")]
        public string Permission{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VirtualPath", this.VirtualPath);
            this.SetParamSimple(map, prefix + "RealPath", this.RealPath);
            this.SetParamSimple(map, prefix + "User", this.User);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
        }
    }
}

