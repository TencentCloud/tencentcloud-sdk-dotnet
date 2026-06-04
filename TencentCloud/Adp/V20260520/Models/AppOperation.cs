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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AppOperation : AbstractModel
    {
        
        /// <summary>
        /// 创建人
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// 创建人UIN
        /// </summary>
        [JsonProperty("CreatorUin")]
        public string CreatorUin{ get; set; }

        /// <summary>
        /// 创建人账号(私有化场景使用)
        /// </summary>
        [JsonProperty("CreatorUserAccount")]
        public string CreatorUserAccount{ get; set; }

        /// <summary>
        /// 修改时间 (Unix时间戳,秒级)
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 最后修改人
        /// </summary>
        [JsonProperty("Updater")]
        public string Updater{ get; set; }

        /// <summary>
        /// 修改人UIN
        /// </summary>
        [JsonProperty("UpdaterUin")]
        public string UpdaterUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "CreatorUin", this.CreatorUin);
            this.SetParamSimple(map, prefix + "CreatorUserAccount", this.CreatorUserAccount);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Updater", this.Updater);
            this.SetParamSimple(map, prefix + "UpdaterUin", this.UpdaterUin);
        }
    }
}

