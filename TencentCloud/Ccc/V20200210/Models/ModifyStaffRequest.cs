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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyStaffRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public ulong? SdkAppId{ get; set; }

        /// <summary>
        /// 座席账户
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 座席名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 座席手机号（带0086前缀,示例：008618011111111）
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 座席昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// 座席工号
        /// </summary>
        [JsonProperty("StaffNo")]
        public string StaffNo{ get; set; }

        /// <summary>
        /// 绑定技能组ID列表
        /// </summary>
        [JsonProperty("SkillGroupIds")]
        public long?[] SkillGroupIds{ get; set; }

        /// <summary>
        /// 是否开启手机外呼开关
        /// </summary>
        [JsonProperty("UseMobileCallOut")]
        public bool? UseMobileCallOut{ get; set; }

        /// <summary>
        /// 手机接听模式 0 - 关闭 | 1 - 仅离线 | 2 - 始终
        /// </summary>
        [JsonProperty("UseMobileAccept")]
        public long? UseMobileAccept{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "StaffNo", this.StaffNo);
            this.SetParamArraySimple(map, prefix + "SkillGroupIds.", this.SkillGroupIds);
            this.SetParamSimple(map, prefix + "UseMobileCallOut", this.UseMobileCallOut);
            this.SetParamSimple(map, prefix + "UseMobileAccept", this.UseMobileAccept);
        }
    }
}

