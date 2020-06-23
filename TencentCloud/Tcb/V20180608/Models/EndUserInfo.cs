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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EndUserInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户唯一ID
        /// </summary>
        [JsonProperty("UUId")]
        public string UUId{ get; set; }

        /// <summary>
        /// 微信ID
        /// </summary>
        [JsonProperty("WXOpenId")]
        public string WXOpenId{ get; set; }

        /// <summary>
        /// qq ID
        /// </summary>
        [JsonProperty("QQOpenId")]
        public string QQOpenId{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonProperty("Gender")]
        public string Gender{ get; set; }

        /// <summary>
        /// 头像地址
        /// </summary>
        [JsonProperty("AvatarUrl")]
        public string AvatarUrl{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 是否为匿名用户
        /// </summary>
        [JsonProperty("IsAnonymous")]
        public bool? IsAnonymous{ get; set; }

        /// <summary>
        /// 是否禁用账户
        /// </summary>
        [JsonProperty("IsDisabled")]
        public bool? IsDisabled{ get; set; }

        /// <summary>
        /// 是否设置过密码
        /// </summary>
        [JsonProperty("HasPassword")]
        public bool? HasPassword{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UUId", this.UUId);
            this.SetParamSimple(map, prefix + "WXOpenId", this.WXOpenId);
            this.SetParamSimple(map, prefix + "QQOpenId", this.QQOpenId);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "AvatarUrl", this.AvatarUrl);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "IsAnonymous", this.IsAnonymous);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
            this.SetParamSimple(map, prefix + "HasPassword", this.HasPassword);
        }
    }
}

