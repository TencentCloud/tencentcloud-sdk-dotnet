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

namespace TencentCloud.Aa.V20200224.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryActivityAntiRushResponse : AbstractModel
    {
        
        /// <summary>
        /// 操作时间戳，单位：秒。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostTime")]
        public string PostTime{ get; set; }

        /// <summary>
        /// 用户操作的真实外网 IP。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 0：表示无恶意。
        /// 1 - 4：恶意等级由低到高。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 风险类型。
        /// 
        /// 账号风险：
        /// 
        /// 1，账号信用低，账号近期存在因恶意被处罚历史，网络低活跃，被举报等因素；
        /// 2，垃圾账号，疑似批量注册小号，近期存在严重违规或大量举报；
        /// 3，无效账号，送检账号参数无法成功解析，请检查微信openid是否有误 ，QQopenid是否与appidU对应，手机号是否有误。
        /// 4，黑名单，该账号在业务侧有过拉黑记录
        /// 5，白名单，该账号在业务侧有过加白名单记录
        /// 
        /// 行为风险：
        /// 101，批量操作，存在ip/设备/环境等因素的聚集性异常；
        /// 102，自动机，疑似自动机批量请求；
        /// 104，微信登录态无效，检查wxToken参数，是否已经失效；
        /// 
        /// 环境风险：
        /// 201，环境异常，操作ip/设备/环境存在异常。当前ip为非常用ip或恶意ip段；
        /// 205，非公网有效ip，传进来的IP地址为内网ip地址或者ip保留地址；
        /// 206，设备异常，该设备存在异常的使用行为
        /// </summary>
        [JsonProperty("RiskType")]
        public long?[] RiskType{ get; set; }

        /// <summary>
        /// accountType是QQ或微信开放账号时，用于标识QQ或微信用户登录后关联业务自身的账号ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// uid值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 用户操作的目的ID 
        /// 比如：点赞，该字段就是被点 赞的消息 id，如果是投票，就是被投号码的 ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RootId")]
        public string RootId{ get; set; }

        /// <summary>
        /// 业务侧错误码。成功时返回Success，错误时返回具体业务错误原因。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeDesc")]
        public string CodeDesc{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "RootId", this.RootId);
            this.SetParamSimple(map, prefix + "CodeDesc", this.CodeDesc);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

