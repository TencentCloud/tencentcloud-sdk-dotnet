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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAdvancedStoreLocationRequest : AbstractModel
    {
        
        /// <summary>
        /// 查询结果保存cos路径
        /// </summary>
        [JsonProperty("StoreLocation")]
        public string StoreLocation{ get; set; }

        /// <summary>
        /// 是否启用高级设置：0-否，1-是
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StoreLocation", this.StoreLocation);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
        }
    }
}

