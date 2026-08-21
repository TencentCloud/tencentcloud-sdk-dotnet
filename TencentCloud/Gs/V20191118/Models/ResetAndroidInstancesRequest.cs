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

    public class ResetAndroidInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID列表</p>
        /// </summary>
        [JsonProperty("AndroidInstanceIds")]
        public string[] AndroidInstanceIds{ get; set; }

        /// <summary>
        /// <p>指定有效的镜像 ID。<br>默认取值：默认使用当前镜像。</p>
        /// </summary>
        [JsonProperty("AndroidInstanceImageId")]
        public string AndroidInstanceImageId{ get; set; }

        /// <summary>
        /// <p>重置模式。在 AndroidInstanceImageId 不为空时才生效。</p><p>CleanData：默认选项，清理系统属性和用户数据<br>KeepSystemProperties：只保留系统属性<br>KeepData: 保留系统属性和用户数据</p>
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AndroidInstanceIds.", this.AndroidInstanceIds);
            this.SetParamSimple(map, prefix + "AndroidInstanceImageId", this.AndroidInstanceImageId);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

