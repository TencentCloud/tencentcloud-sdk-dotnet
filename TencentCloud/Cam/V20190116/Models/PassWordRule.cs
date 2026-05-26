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

namespace TencentCloud.Cam.V20190116.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PassWordRule : AbstractModel
    {
        
        /// <summary>
        /// 最小长度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MinimumLength")]
        public long? MinimumLength{ get; set; }

        /// <summary>
        /// 必须包含的字符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MustContain")]
        public string MustContain{ get; set; }

        /// <summary>
        /// 强制修改周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ForcePasswordChange")]
        public long? ForcePasswordChange{ get; set; }

        /// <summary>
        /// 重复使用次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReusePasswordLimit")]
        public long? ReusePasswordLimit{ get; set; }

        /// <summary>
        /// 密码重试次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RetryPasswordLimit")]
        public long? RetryPasswordLimit{ get; set; }

        /// <summary>
        /// 密码过期失效 1：是，2：否（是：密码过期后，子用户无法登录，需要管理员重置密码。否：密码过期后，子用户可登录，登录后强制根据旧密码修改密码）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PasswordExpirationInvalidation")]
        public long? PasswordExpirationInvalidation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinimumLength", this.MinimumLength);
            this.SetParamSimple(map, prefix + "MustContain", this.MustContain);
            this.SetParamSimple(map, prefix + "ForcePasswordChange", this.ForcePasswordChange);
            this.SetParamSimple(map, prefix + "ReusePasswordLimit", this.ReusePasswordLimit);
            this.SetParamSimple(map, prefix + "RetryPasswordLimit", this.RetryPasswordLimit);
            this.SetParamSimple(map, prefix + "PasswordExpirationInvalidation", this.PasswordExpirationInvalidation);
        }
    }
}

