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

namespace TencentCloud.Trro.V20220325.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyProjectSecModeRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 安全模式  
        /// 0：关闭项目共享密钥 
        /// 1：开启项目共享密钥
        /// </summary>
        [JsonProperty("Mode")]
        public long? Mode{ get; set; }

        /// <summary>
        /// 项目密钥 32位 小写英文+数字；  项目密钥模式必填
        /// </summary>
        [JsonProperty("Key")]
        public string Key{ get; set; }

        /// <summary>
        /// 自动注册方式
        /// 0：关闭自动注册
        /// 1：仅允许现场设备自动注册
        /// 2：仅允许远端设备自动注册
        /// 3：允许现场和远端设备均自动注册
        /// </summary>
        [JsonProperty("AutoRegister")]
        public long? AutoRegister{ get; set; }

        /// <summary>
        /// 是否允许远端获取现场设备列表（getGwList）
        /// 0：不允许
        /// 1：允许
        /// </summary>
        [JsonProperty("FieldListEnable")]
        public long? FieldListEnable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
            this.SetParamSimple(map, prefix + "Key", this.Key);
            this.SetParamSimple(map, prefix + "AutoRegister", this.AutoRegister);
            this.SetParamSimple(map, prefix + "FieldListEnable", this.FieldListEnable);
        }
    }
}

