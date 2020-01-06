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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 配置项发布历史ID
        /// </summary>
        [JsonProperty("ConfigReleaseLogId")]
        public string ConfigReleaseLogId{ get; set; }

        /// <summary>
        /// 回滚描述
        /// </summary>
        [JsonProperty("ReleaseDesc")]
        public string ReleaseDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigReleaseLogId", this.ConfigReleaseLogId);
            this.SetParamSimple(map, prefix + "ReleaseDesc", this.ReleaseDesc);
        }
    }
}

