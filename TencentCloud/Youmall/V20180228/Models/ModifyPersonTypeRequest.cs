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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPersonTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 集团ID
        /// </summary>
        [JsonProperty("CompanyId")]
        public string CompanyId{ get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("ShopId")]
        public ulong? ShopId{ get; set; }

        /// <summary>
        /// 顾客ID
        /// </summary>
        [JsonProperty("PersonId")]
        public ulong? PersonId{ get; set; }

        /// <summary>
        /// 身份类型(0表示普通顾客，1 白名单，2 表示黑名单）
        /// </summary>
        [JsonProperty("PersonType")]
        public ulong? PersonType{ get; set; }

        /// <summary>
        /// 身份子类型:
        /// PersonType=0时(普通顾客)，0普通顾客
        /// PersonType=1时(白名单)，0店员，1商场人员，2其他类型人员，3区域经理，4注册会员，5VIP用户
        /// PersonType=2时(黑名单)，0普通黑名单，1小偷)
        /// </summary>
        [JsonProperty("PersonSubType")]
        public ulong? PersonSubType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyId", this.CompanyId);
            this.SetParamSimple(map, prefix + "ShopId", this.ShopId);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "PersonType", this.PersonType);
            this.SetParamSimple(map, prefix + "PersonSubType", this.PersonSubType);
        }
    }
}

