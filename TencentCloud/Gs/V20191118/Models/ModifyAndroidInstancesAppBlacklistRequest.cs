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

namespace TencentCloud.Gs.V20191118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAndroidInstancesAppBlacklistRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID列表，数量上限100
        /// </summary>
        [JsonProperty("AndroidInstanceIds")]
        public string[] AndroidInstanceIds{ get; set; }

        /// <summary>
        /// 应用列表
        /// </summary>
        [JsonProperty("AppList")]
        public string[] AppList{ get; set; }

        /// <summary>
        /// ADD、REMOVE、CLEAR
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AndroidInstanceIds.", this.AndroidInstanceIds);
            this.SetParamArraySimple(map, prefix + "AppList.", this.AppList);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
        }
    }
}

