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

namespace TencentCloud.Vcube.V20220410.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTestXMagicRequest : AbstractModel
    {
        
        /// <summary>
        /// 将腾讯特效创建到哪个应用下
        /// </summary>
        [JsonProperty("ApplicationId")]
        public ulong? ApplicationId{ get; set; }

        /// <summary>
        /// 营业执照
        /// </summary>
        [JsonProperty("CompanyPermit")]
        public string CompanyPermit{ get; set; }

        /// <summary>
        /// 公司类型
        /// </summary>
        [JsonProperty("CompanyType")]
        public string CompanyType{ get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// 测试套餐名称
        /// </summary>
        [JsonProperty("PlanList")]
        public string[] PlanList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "CompanyPermit", this.CompanyPermit);
            this.SetParamSimple(map, prefix + "CompanyType", this.CompanyType);
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamArraySimple(map, prefix + "PlanList.", this.PlanList);
        }
    }
}

