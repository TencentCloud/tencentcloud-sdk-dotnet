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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BankCardVerificationRequest : AbstractModel
    {
        
        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 银行卡
        /// </summary>
        [JsonProperty("BankCard")]
        public string BankCard{ get; set; }

        /// <summary>
        /// 证件类型（不填默认0）
        /// 0 身份证
        /// 1 军官证
        /// 2 护照
        /// 3 港澳证
        /// 4 台胞证
        /// 5 警官证
        /// 6 士兵证
        /// 7 其它证件
        /// </summary>
        [JsonProperty("CertType")]
        public long? CertType{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BankCard", this.BankCard);
            this.SetParamSimple(map, prefix + "CertType", this.CertType);
        }
    }
}

