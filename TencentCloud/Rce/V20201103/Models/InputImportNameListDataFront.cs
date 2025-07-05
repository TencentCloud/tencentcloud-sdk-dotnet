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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputImportNameListDataFront : AbstractModel
    {
        
        /// <summary>
        /// 名单ID
        /// </summary>
        [JsonProperty("NameListId")]
        public long? NameListId{ get; set; }

        /// <summary>
        /// 数据来源，固定传2（手工录入）
        /// </summary>
        [JsonProperty("DataSource")]
        public long? DataSource{ get; set; }

        /// <summary>
        /// 黑白名单数据内容
        /// </summary>
        [JsonProperty("DataContentInfo")]
        public DataContentInfo[] DataContentInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NameListId", this.NameListId);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamArrayObj(map, prefix + "DataContentInfo.", this.DataContentInfo);
        }
    }
}

