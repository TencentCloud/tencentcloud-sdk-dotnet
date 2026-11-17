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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChcDeployExtraConfig : AbstractModel
    {
        
        /// <summary>
        /// <p>MiniOS类型。是使用腾讯云的MiniOS，还是客户私有的MiniOS。</p><p>枚举值：</p><ul><li>public： 腾讯云的MiniOS。</li><li>private： 客户私有的MiniOS。</li></ul>
        /// </summary>
        [JsonProperty("MiniOsType")]
        public string MiniOsType{ get; set; }

        /// <summary>
        /// <p>服务器的架构和启动方式。</p><p>枚举值：</p><ul><li>x86_legacy： X86架构、Legacy启动模式。</li><li>x86_uefi： X86架构、UEFI启动模式。</li><li>arm_uefi： ARM架构，UEFI启动模式。</li></ul>
        /// </summary>
        [JsonProperty("BootType")]
        public string BootType{ get; set; }

        /// <summary>
        /// <p>PXE使用的引导文件。默认为pxelinux.0。</p>
        /// </summary>
        [JsonProperty("BootFile")]
        public string BootFile{ get; set; }

        /// <summary>
        /// <p>TFTP服务器的IP地址。</p>
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

