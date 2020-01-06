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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputMapping : AbstractModel
    {
        
        /// <summary>
        /// 源端路径
        /// </summary>
        [JsonProperty("SourcePath")]
        public string SourcePath{ get; set; }

        /// <summary>
        /// 目的端路径
        /// </summary>
        [JsonProperty("DestinationPath")]
        public string DestinationPath{ get; set; }

        /// <summary>
        /// 挂载配置项参数
        /// </summary>
        [JsonProperty("MountOptionParameter")]
        public string MountOptionParameter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourcePath", this.SourcePath);
            this.SetParamSimple(map, prefix + "DestinationPath", this.DestinationPath);
            this.SetParamSimple(map, prefix + "MountOptionParameter", this.MountOptionParameter);
        }
    }
}

