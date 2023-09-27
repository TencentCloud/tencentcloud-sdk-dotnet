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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApproverOption : AbstractModel
    {
        
        /// <summary>
        /// 是否隐藏一键签署 默认false-不隐藏true-隐藏
        /// </summary>
        [JsonProperty("HideOneKeySign")]
        public bool? HideOneKeySign{ get; set; }

        /// <summary>
        /// 签署人信息补充类型，默认无需补充。
        /// 
        /// <ul><li> **1** : ( 动态签署人（可发起合同后再补充签署人信息）</li>
        /// </ul>
        /// </summary>
        [JsonProperty("FillType")]
        public long? FillType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "HideOneKeySign", this.HideOneKeySign);
            this.SetParamSimple(map, prefix + "FillType", this.FillType);
        }
    }
}

