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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryCustomersCreditData : AbstractModel
    {
        
        /// <summary>
        /// 名字
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        [JsonProperty("Email")]
        public string Email{ get; set; }

        /// <summary>
        /// 欠费标记
        /// </summary>
        [JsonProperty("Arrears")]
        public string Arrears{ get; set; }

        /// <summary>
        /// 绑定时间
        /// </summary>
        [JsonProperty("AssociationTime")]
        public string AssociationTime{ get; set; }

        /// <summary>
        /// 最近到期时间
        /// </summary>
        [JsonProperty("RecentExpiry")]
        public string RecentExpiry{ get; set; }

        /// <summary>
        /// 子客uin
        /// </summary>
        [JsonProperty("ClientUin")]
        public ulong? ClientUin{ get; set; }

        /// <summary>
        /// 子客授信额度
        /// </summary>
        [JsonProperty("Credit")]
        public float? Credit{ get; set; }

        /// <summary>
        /// 子客剩余额度
        /// </summary>
        [JsonProperty("RemainingCredit")]
        public float? RemainingCredit{ get; set; }

        /// <summary>
        /// 0：未实名 1: 个人实名 2：企业实名
        /// </summary>
        [JsonProperty("IdentifyType")]
        public ulong? IdentifyType{ get; set; }

        /// <summary>
        /// 客户备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 强制状态
        /// </summary>
        [JsonProperty("Force")]
        public long? Force{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
            this.SetParamSimple(map, prefix + "Email", this.Email);
            this.SetParamSimple(map, prefix + "Arrears", this.Arrears);
            this.SetParamSimple(map, prefix + "AssociationTime", this.AssociationTime);
            this.SetParamSimple(map, prefix + "RecentExpiry", this.RecentExpiry);
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "Credit", this.Credit);
            this.SetParamSimple(map, prefix + "RemainingCredit", this.RemainingCredit);
            this.SetParamSimple(map, prefix + "IdentifyType", this.IdentifyType);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "Force", this.Force);
        }
    }
}

