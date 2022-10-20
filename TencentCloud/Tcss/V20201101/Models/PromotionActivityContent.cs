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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PromotionActivityContent : AbstractModel
    {
        
        /// <summary>
        /// 月数
        /// </summary>
        [JsonProperty("MonthNum")]
        public ulong? MonthNum{ get; set; }

        /// <summary>
        /// 核数最低限量
        /// </summary>
        [JsonProperty("CoresCountLimit")]
        public ulong? CoresCountLimit{ get; set; }

        /// <summary>
        /// 专业版折扣
        /// </summary>
        [JsonProperty("ProfessionalDiscount")]
        public ulong? ProfessionalDiscount{ get; set; }

        /// <summary>
        /// 附赠镜像数
        /// </summary>
        [JsonProperty("ImageAuthorizationNum")]
        public ulong? ImageAuthorizationNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MonthNum", this.MonthNum);
            this.SetParamSimple(map, prefix + "CoresCountLimit", this.CoresCountLimit);
            this.SetParamSimple(map, prefix + "ProfessionalDiscount", this.ProfessionalDiscount);
            this.SetParamSimple(map, prefix + "ImageAuthorizationNum", this.ImageAuthorizationNum);
        }
    }
}

