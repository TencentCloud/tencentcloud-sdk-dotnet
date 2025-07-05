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

namespace TencentCloud.Ams.V20201229.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class User : AbstractModel
    {
        
        /// <summary>
        /// 用户等级，默认0 未知 1 低 2 中 3 高
        /// </summary>
        [JsonProperty("Level")]
        public ulong? Level{ get; set; }

        /// <summary>
        /// 性别 默认0 未知 1 男性 2 女性
        /// </summary>
        [JsonProperty("Gender")]
        public ulong? Gender{ get; set; }

        /// <summary>
        /// 年龄 默认0 未知
        /// </summary>
        [JsonProperty("Age")]
        public ulong? Age{ get; set; }

        /// <summary>
        /// 业务用户ID 如填写，会根据账号历史恶意情况，判定消息有害结果，特别是有利于可疑恶意情况下的辅助判断。账号可以填写微信uin、QQ号、微信openid、QQopenid、字符串等。该字段和账号类别确定唯一账号。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// 业务用户ID类型 "1-微信uin 2-QQ号 3-微信群uin 4-qq群号 5-微信openid 6-QQopenid 7-其它string"
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 用户昵称
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 用户头像图片链接
        /// </summary>
        [JsonProperty("HeadUrl")]
        public string HeadUrl{ get; set; }

        /// <summary>
        /// 用户简介，长度不超过5000字
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 群聊场景房间ID
        /// </summary>
        [JsonProperty("RoomId")]
        public string RoomId{ get; set; }

        /// <summary>
        /// 群聊场景群ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 群聊场景群用户数
        /// </summary>
        [JsonProperty("GroupSize")]
        public long? GroupSize{ get; set; }

        /// <summary>
        /// 消息接收者ID
        /// </summary>
        [JsonProperty("ReceiverId")]
        public string ReceiverId{ get; set; }

        /// <summary>
        /// 消息生成时间，毫秒
        /// </summary>
        [JsonProperty("SendTime")]
        public string SendTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "HeadUrl", this.HeadUrl);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "RoomId", this.RoomId);
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupSize", this.GroupSize);
            this.SetParamSimple(map, prefix + "ReceiverId", this.ReceiverId);
            this.SetParamSimple(map, prefix + "SendTime", this.SendTime);
        }
    }
}

