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

namespace TencentCloud.Ims.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class User : AbstractModel
    {
        
        /// <summary>
        /// 该字段表示业务用户ID,填写后，系统可根据账号过往违规历史优化审核结果判定，有利于存在可疑违规风险时的辅助判断。<br>
        /// 备注：该字段可传入微信openid、QQopenid、字符串等账号信息，与账号类别参数（AccountType）配合使用可确定唯一账号。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 该字段表示业务用户对应的账号昵称信息。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 该字段表示业务用户ID对应的账号类型，取值：**1**-微信uin，**2**-QQ号，**3**-微信群uin，**4**-qq群号，**5**-微信openid，**6**-QQopenid，**7**-其它string。<br>
        /// 该字段与账号ID参数（UserId）配合使用可确定唯一账号。
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 该字段表示业务用户对应账号的性别信息。<br>
        /// 取值：**0**（默认值，代表性别未知）、**1**（男性）、**2**（女性）。
        /// </summary>
        [JsonProperty("Gender")]
        public ulong? Gender{ get; set; }

        /// <summary>
        /// 该字段表示业务用户对应账号的年龄信息。<br>
        /// 取值：**0**（默认值，代表年龄未知）-（**自定义年龄上限**）之间的整数。
        /// </summary>
        [JsonProperty("Age")]
        public ulong? Age{ get; set; }

        /// <summary>
        /// 该字段表示业务用户对应账号的等级信息。<br>
        /// 取值：**0**（默认值，代表等级未知）、**1**（等级较低）、**2**（等级中等）、**3**（等级较高），目前**暂不支持自定义等级**。
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 该字段表示业务用户对应账号的手机号信息，支持全球各地区手机号的记录。<br>
        /// 备注：请保持手机号格式的统一，如区号格式（086/+86）等。
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 该字段表示业务用户的简介信息，支持汉字、英文及特殊符号，**长度不超过5000个汉字字符**。
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 该字段表示业务用户头像图片的访问链接(URL)，支持PNG、JPG、JPEG、BMP、GIF、WEBP格式。<br>备注：头像图片**大小不超过5MB**，建议**分辨率不低于256x256**；图片下载时间限制为3秒，超过则会返回下载超时。
        /// </summary>
        [JsonProperty("HeadUrl")]
        public string HeadUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "HeadUrl", this.HeadUrl);
        }
    }
}

