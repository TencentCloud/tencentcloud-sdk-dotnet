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

    public class SeatUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 座席名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 座席邮箱
        /// </summary>
        [JsonProperty("Mail")]
        public string Mail{ get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        [JsonProperty("StaffNumber")]
        public string StaffNumber{ get; set; }

        /// <summary>
        /// 座席电话号码（带0086前缀）
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 座席昵称
        /// </summary>
        [JsonProperty("Nick")]
        public string Nick{ get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 座席关联的技能组列表
        /// </summary>
        [JsonProperty("SkillGroupNameList")]
        public string[] SkillGroupNameList{ get; set; }

        /// <summary>
        /// 1:管理员
        /// 2:质检员
        /// 3:普通座席
        /// else:自定义角色ID
        /// </summary>
        [JsonProperty("Role")]
        public long? Role{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Mail", this.Mail);
            this.SetParamSimple(map, prefix + "StaffNumber", this.StaffNumber);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Nick", this.Nick);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamArraySimple(map, prefix + "SkillGroupNameList.", this.SkillGroupNameList);
            this.SetParamSimple(map, prefix + "Role", this.Role);
        }
    }
}

