/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DlcPartitionInfo : AbstractModel
    {
        
        /// <summary>
        /// cls日志中的字段名
        /// </summary>
        [JsonProperty("ClsField")]
        public string ClsField{ get; set; }

        /// <summary>
        /// dlc表的列名
        /// </summary>
        [JsonProperty("DlcField")]
        public string DlcField{ get; set; }

        /// <summary>
        /// dlc字段类型
        /// </summary>
        [JsonProperty("DlcFieldType")]
        public string DlcFieldType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClsField", this.ClsField);
            this.SetParamSimple(map, prefix + "DlcField", this.DlcField);
            this.SetParamSimple(map, prefix + "DlcFieldType", this.DlcFieldType);
        }
    }
}

