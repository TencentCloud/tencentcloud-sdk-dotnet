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

namespace TencentCloud.Mrs.V20200910.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BirthCert : AbstractModel
    {
        
        /// <summary>
        /// 新生儿信息
        /// </summary>
        [JsonProperty("NeonatalInfo")]
        public NeonatalInfo NeonatalInfo{ get; set; }

        /// <summary>
        /// 母亲信息
        /// </summary>
        [JsonProperty("MotherInfo")]
        public ParentInfo MotherInfo{ get; set; }

        /// <summary>
        /// 父亲信息
        /// </summary>
        [JsonProperty("FatherInfo")]
        public ParentInfo FatherInfo{ get; set; }

        /// <summary>
        /// 签发信息
        /// </summary>
        [JsonProperty("IssueInfo")]
        public IssueInfo IssueInfo{ get; set; }

        /// <summary>
        /// 数据在原PDF文件中的第几页
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "NeonatalInfo.", this.NeonatalInfo);
            this.SetParamObj(map, prefix + "MotherInfo.", this.MotherInfo);
            this.SetParamObj(map, prefix + "FatherInfo.", this.FatherInfo);
            this.SetParamObj(map, prefix + "IssueInfo.", this.IssueInfo);
            this.SetParamSimple(map, prefix + "Page", this.Page);
        }
    }
}

