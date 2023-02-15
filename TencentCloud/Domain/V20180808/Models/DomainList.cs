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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DomainList : AbstractModel
    {
        
        /// <summary>
        /// 是否是溢价域名：
        /// ture 是    
        /// false 不是
        /// </summary>
        [JsonProperty("IsPremium")]
        public bool? IsPremium{ get; set; }

        /// <summary>
        /// 域名资源ID。
        /// </summary>
        [JsonProperty("DomainId")]
        public string DomainId{ get; set; }

        /// <summary>
        /// 域名名称。
        /// </summary>
        [JsonProperty("DomainName")]
        public string DomainName{ get; set; }

        /// <summary>
        /// 是否已设置自动续费 。
        /// 0：未设置 
        /// 1：已设置
        /// 2：设置后，关闭
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// 注册时间。
        /// </summary>
        [JsonProperty("CreationDate")]
        public string CreationDate{ get; set; }

        /// <summary>
        /// 到期时间。
        /// </summary>
        [JsonProperty("ExpirationDate")]
        public string ExpirationDate{ get; set; }

        /// <summary>
        /// 域名后缀
        /// </summary>
        [JsonProperty("Tld")]
        public string Tld{ get; set; }

        /// <summary>
        /// 编码后的后缀（中文会进行编码）
        /// </summary>
        [JsonProperty("CodeTld")]
        public string CodeTld{ get; set; }

        /// <summary>
        /// 域名购买状态。
        /// ok：正常
        /// AboutToExpire: 即将到期
        /// RegisterPending：注册中
        /// RegisterDoing：注册中
        /// RegisterFailed：注册失败
        /// RenewPending：续费期
        /// RenewDoing：续费中
        /// RedemptionPending：赎回期
        /// RedemptionDoing：赎回中
        /// TransferPending：转入中
        /// TransferTransing：转入中
        /// TransferFailed：转入失败
        /// </summary>
        [JsonProperty("BuyStatus")]
        public string BuyStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsPremium", this.IsPremium);
            this.SetParamSimple(map, prefix + "DomainId", this.DomainId);
            this.SetParamSimple(map, prefix + "DomainName", this.DomainName);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "CreationDate", this.CreationDate);
            this.SetParamSimple(map, prefix + "ExpirationDate", this.ExpirationDate);
            this.SetParamSimple(map, prefix + "Tld", this.Tld);
            this.SetParamSimple(map, prefix + "CodeTld", this.CodeTld);
            this.SetParamSimple(map, prefix + "BuyStatus", this.BuyStatus);
        }
    }
}

