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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MigrationConflict : AbstractModel
    {
        
        /// <summary>
        /// <p>migration 版本号</p><p>参数格式：纯数字，14位时间格式</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>migration 版本名</p><p>参数格式：仅允许小写字母和下划线</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>数据库已应用migration的版本名</p><p>参数格式：仅允许小写字母和下划线</p>
        /// </summary>
        [JsonProperty("RemoteName")]
        public string RemoteName{ get; set; }

        /// <summary>
        /// <p>本次sql计算出来的checksum</p>
        /// </summary>
        [JsonProperty("LocalChecksum")]
        public string LocalChecksum{ get; set; }

        /// <summary>
        /// <p>已应用的migration，数据库存储的checksum</p>
        /// </summary>
        [JsonProperty("RemoteChecksum")]
        public string RemoteChecksum{ get; set; }

        /// <summary>
        /// <p>归入该分组的原因</p>
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// <p>冲突信息</p>
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "RemoteName", this.RemoteName);
            this.SetParamSimple(map, prefix + "LocalChecksum", this.LocalChecksum);
            this.SetParamSimple(map, prefix + "RemoteChecksum", this.RemoteChecksum);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "Message", this.Message);
        }
    }
}

