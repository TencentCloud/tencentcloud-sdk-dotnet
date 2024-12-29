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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChcDeployExtraConfig : AbstractModel
    {
        
        /// <summary>
        /// minos类型。是使用腾讯云的minios，还是客户自己的minios。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MiniOsType")]
        public string MiniOsType{ get; set; }

        /// <summary>
        /// 服务器的架构和启动方式。取值为x86_legacy, arm_uefi。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BootType")]
        public string BootType{ get; set; }

        /// <summary>
        /// PXE使用的引导文件。默认为pxelinux.0。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BootFile")]
        public string BootFile{ get; set; }

        /// <summary>
        /// tftp服务器的ip地址。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextServerAddress")]
        public string NextServerAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MiniOsType", this.MiniOsType);
            this.SetParamSimple(map, prefix + "BootType", this.BootType);
            this.SetParamSimple(map, prefix + "BootFile", this.BootFile);
            this.SetParamSimple(map, prefix + "NextServerAddress", this.NextServerAddress);
        }
    }
}

