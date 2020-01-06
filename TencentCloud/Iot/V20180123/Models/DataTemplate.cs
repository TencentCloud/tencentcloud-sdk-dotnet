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

namespace TencentCloud.Iot.V20180123.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DataTemplate : AbstractModel
    {
        
        /// <summary>
        /// 数字类型
        /// </summary>
        [JsonProperty("Number")]
        public NumberData Number{ get; set; }

        /// <summary>
        /// 字符串类型
        /// </summary>
        [JsonProperty("String")]
        public StringData String{ get; set; }

        /// <summary>
        /// 枚举类型
        /// </summary>
        [JsonProperty("Enum")]
        public EnumData Enum{ get; set; }

        /// <summary>
        /// 布尔类型
        /// </summary>
        [JsonProperty("Bool")]
        public BoolData Bool{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Number.", this.Number);
            this.SetParamObj(map, prefix + "String.", this.String);
            this.SetParamObj(map, prefix + "Enum.", this.Enum);
            this.SetParamObj(map, prefix + "Bool.", this.Bool);
        }
    }
}

