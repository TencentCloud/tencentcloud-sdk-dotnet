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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StreamConnectProjectInput : AbstractModel
    {
        
        /// <summary>
        /// 云转推主输入源信息。
        /// </summary>
        [JsonProperty("MainInput")]
        public StreamInputInfo MainInput{ get; set; }

        /// <summary>
        /// 云转推备输入源信息。
        /// </summary>
        [JsonProperty("BackupInput")]
        public StreamInputInfo BackupInput{ get; set; }

        /// <summary>
        /// 云转推输出源信息。
        /// </summary>
        [JsonProperty("Outputs")]
        public StreamConnectOutput[] Outputs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "MainInput.", this.MainInput);
            this.SetParamObj(map, prefix + "BackupInput.", this.BackupInput);
            this.SetParamArrayObj(map, prefix + "Outputs.", this.Outputs);
        }
    }
}

