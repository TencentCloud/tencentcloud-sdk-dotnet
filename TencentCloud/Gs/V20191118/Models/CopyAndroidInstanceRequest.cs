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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyAndroidInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 源安卓实例 ID
        /// </summary>
        [JsonProperty("SourceAndroidInstanceId")]
        public string SourceAndroidInstanceId{ get; set; }

        /// <summary>
        /// 目的安卓实例 ID
        /// </summary>
        [JsonProperty("TargetAndroidInstanceId")]
        public string TargetAndroidInstanceId{ get; set; }

        /// <summary>
        /// 包含的路径，支持仅含一个通配符*，通配符不能出现在路径开始
        /// </summary>
        [JsonProperty("Includes")]
        public string[] Includes{ get; set; }

        /// <summary>
        /// 需要排除路径，支持仅含一个通配符*，通配符不能出现在路径开始
        /// </summary>
        [JsonProperty("Excludes")]
        public string[] Excludes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SourceAndroidInstanceId", this.SourceAndroidInstanceId);
            this.SetParamSimple(map, prefix + "TargetAndroidInstanceId", this.TargetAndroidInstanceId);
            this.SetParamArraySimple(map, prefix + "Includes.", this.Includes);
            this.SetParamArraySimple(map, prefix + "Excludes.", this.Excludes);
        }
    }
}

