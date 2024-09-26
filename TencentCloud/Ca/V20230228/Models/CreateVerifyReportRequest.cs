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

namespace TencentCloud.Ca.V20230228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVerifyReportRequest : AbstractModel
    {
        
        /// <summary>
        /// 客户类型 1:个人，2:企业
        /// </summary>
        [JsonProperty("ApplyCustomerType")]
        public string ApplyCustomerType{ get; set; }

        /// <summary>
        /// 申请企业 or 自然人名称
        /// </summary>
        [JsonProperty("ApplyCustomerName")]
        public string ApplyCustomerName{ get; set; }

        /// <summary>
        /// 验签申请人姓名
        /// </summary>
        [JsonProperty("ApplyName")]
        public string ApplyName{ get; set; }

        /// <summary>
        /// 验签申请人电弧
        /// </summary>
        [JsonProperty("ApplyMobile")]
        public string ApplyMobile{ get; set; }

        /// <summary>
        /// 验签文件id
        /// </summary>
        [JsonProperty("FileId")]
        public string FileId{ get; set; }

        /// <summary>
        /// 验签申请人邮箱
        /// </summary>
        [JsonProperty("ApplyEmail")]
        public string ApplyEmail{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplyCustomerType", this.ApplyCustomerType);
            this.SetParamSimple(map, prefix + "ApplyCustomerName", this.ApplyCustomerName);
            this.SetParamSimple(map, prefix + "ApplyName", this.ApplyName);
            this.SetParamSimple(map, prefix + "ApplyMobile", this.ApplyMobile);
            this.SetParamSimple(map, prefix + "FileId", this.FileId);
            this.SetParamSimple(map, prefix + "ApplyEmail", this.ApplyEmail);
        }
    }
}

