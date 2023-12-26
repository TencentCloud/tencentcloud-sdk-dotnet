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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterConfigsInfoFromEMR : AbstractModel
    {
        
        /// <summary>
        /// 配置文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 配置文件对应的相关属性信息
        /// </summary>
        [JsonProperty("FileConf")]
        public string FileConf{ get; set; }

        /// <summary>
        /// 配置文件对应的其他属性信息
        /// </summary>
        [JsonProperty("KeyConf")]
        public string KeyConf{ get; set; }

        /// <summary>
        /// 配置文件的内容，base64编码
        /// </summary>
        [JsonProperty("OriParam")]
        public string OriParam{ get; set; }

        /// <summary>
        /// 用于表示当前配置文件是不是有过修改后没有重启，提醒用户需要重启
        /// </summary>
        [JsonProperty("NeedRestart")]
        public long? NeedRestart{ get; set; }

        /// <summary>
        /// 配置文件路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilePath")]
        public string FilePath{ get; set; }

        /// <summary>
        /// 配置文件kv值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileKeyValues")]
        [System.Obsolete]
        public string FileKeyValues{ get; set; }

        /// <summary>
        /// 配置文件kv值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FileKeyValuesNew")]
        public ConfigKeyValue[] FileKeyValuesNew{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileConf", this.FileConf);
            this.SetParamSimple(map, prefix + "KeyConf", this.KeyConf);
            this.SetParamSimple(map, prefix + "OriParam", this.OriParam);
            this.SetParamSimple(map, prefix + "NeedRestart", this.NeedRestart);
            this.SetParamSimple(map, prefix + "FilePath", this.FilePath);
            this.SetParamSimple(map, prefix + "FileKeyValues", this.FileKeyValues);
            this.SetParamArrayObj(map, prefix + "FileKeyValuesNew.", this.FileKeyValuesNew);
        }
    }
}

