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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAppPasswordRequest : AbstractModel
    {
        
        /// <summary>
        /// 需要修改密码的应用实例ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用旧密码
        /// </summary>
        [JsonProperty("OldPassword")]
        public string OldPassword{ get; set; }

        /// <summary>
        /// 应用旧密码预期失效时间
        /// </summary>
        [JsonProperty("OldPasswordExpireTime")]
        public string OldPasswordExpireTime{ get; set; }

        /// <summary>
        /// 应用新密码
        /// </summary>
        [JsonProperty("NewPassword")]
        public string NewPassword{ get; set; }

        /// <summary>
        /// 更新模式： `1` 更新密码；`2` 更新旧密码失效时间，默认为`1` 模式
        /// </summary>
        [JsonProperty("Mode")]
        public string Mode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "OldPassword", this.OldPassword);
            this.SetParamSimple(map, prefix + "OldPasswordExpireTime", this.OldPasswordExpireTime);
            this.SetParamSimple(map, prefix + "NewPassword", this.NewPassword);
            this.SetParamSimple(map, prefix + "Mode", this.Mode);
        }
    }
}

