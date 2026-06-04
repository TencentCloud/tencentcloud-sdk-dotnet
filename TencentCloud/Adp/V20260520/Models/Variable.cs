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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Variable : AbstractModel
    {
        
        /// <summary>
        /// 默认文件名称
        /// </summary>
        [JsonProperty("DefaultFileName")]
        public string DefaultFileName{ get; set; }

        /// <summary>
        /// 默认值
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// 变量描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 模块类型。枚举值: 1:环境参数, 2:应用参数, 3:系统参数, -1:所有参数
        /// </summary>
        [JsonProperty("ModuleType")]
        public long? ModuleType{ get; set; }

        /// <summary>
        /// 变量名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 变量类型。枚举值: 1:字符串, 2:整数, 3:浮点数, 4:布尔值, 5:对象, 6:字符串数组, 7:整数数组, 8:浮点数数组, 9:布尔值数组, 10:对象数组, 11:文件, 12:文档, 13:图片, 14:音频, 15:视频, 16:文件数组, 17:文档数组, 18:图片数组, 19:音频数组, 20:视频数组, 21:数组的数组, 22:密钥/敏感信息, 99:空值
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 变量ID
        /// </summary>
        [JsonProperty("VariableId")]
        public string VariableId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DefaultFileName", this.DefaultFileName);
            this.SetParamSimple(map, prefix + "DefaultValue", this.DefaultValue);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ModuleType", this.ModuleType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "VariableId", this.VariableId);
        }
    }
}

