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
        /// <p>默认文件名称</p>
        /// </summary>
        [JsonProperty("DefaultFileName")]
        public string DefaultFileName{ get; set; }

        /// <summary>
        /// <p>默认值</p>
        /// </summary>
        [JsonProperty("DefaultValue")]
        public string DefaultValue{ get; set; }

        /// <summary>
        /// <p>变量描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>模块类型。枚举值: 1:环境参数, 2:应用参数, 3:系统参数, -1:所有参数</p>
        /// </summary>
        [JsonProperty("ModuleType")]
        public long? ModuleType{ get; set; }

        /// <summary>
        /// <p>变量名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>变量类型</p><p>枚举值：</p><ul><li>0： 字符串</li><li>1： 整数</li><li>2： 浮点数</li><li>3： 布尔值</li><li>4： 对象</li><li>5： 字符串数组</li><li>6： 整数数组</li><li>7： 浮点数数组</li><li>8： 布尔值数组</li><li>9： 对象数组</li><li>10： 文件</li><li>11： 文档</li><li>12： 图片</li><li>13： 音频</li><li>14： 视频</li><li>15： 文件数组</li><li>16： 文档数组</li><li>17： 图片数组</li><li>18： 音频数组</li><li>19： 视频数组</li><li>20： 数组的数组</li><li>21： 密钥</li></ul>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// <p>变量ID</p>
        /// </summary>
        [JsonProperty("VariableId")]
        public string VariableId{ get; set; }

        /// <summary>
        /// <p>是否启用网络策略(仅环境变量生效)</p>
        /// </summary>
        [JsonProperty("EnableEndpoints")]
        public bool? EnableEndpoints{ get; set; }

        /// <summary>
        /// <p>网络策略列表(支持: 精确域名、*.通配子域名、可带协议/端口/路径前缀)</p>
        /// </summary>
        [JsonProperty("EndpointList")]
        public string[] EndpointList{ get; set; }


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
            this.SetParamSimple(map, prefix + "EnableEndpoints", this.EnableEndpoints);
            this.SetParamArraySimple(map, prefix + "EndpointList.", this.EndpointList);
        }
    }
}

