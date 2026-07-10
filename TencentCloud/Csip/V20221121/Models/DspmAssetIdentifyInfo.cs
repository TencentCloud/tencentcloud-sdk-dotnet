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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DspmAssetIdentifyInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>资产实例id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>资产名称</p>
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// <p>资产类型</p><p>枚举值：</p><ul><li>cdb： MySQL</li><li>mariadb： MariaDB</li><li>mongodb： MongoDB</li></ul>
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// <p>已检出数据库数量</p>
        /// </summary>
        [JsonProperty("DetectedDbCount")]
        public ulong? DetectedDbCount{ get; set; }

        /// <summary>
        /// <p>已检出表数量</p>
        /// </summary>
        [JsonProperty("DetectedTableCount")]
        public ulong? DetectedTableCount{ get; set; }

        /// <summary>
        /// <p>数据项id集合</p>
        /// </summary>
        [JsonProperty("RuleIds")]
        public ulong?[] RuleIds{ get; set; }

        /// <summary>
        /// <p>数据项名称集合</p>
        /// </summary>
        [JsonProperty("RuleNames")]
        public string[] RuleNames{ get; set; }

        /// <summary>
        /// <p>分类id集合</p>
        /// </summary>
        [JsonProperty("CategoryIds")]
        public ulong?[] CategoryIds{ get; set; }

        /// <summary>
        /// <p>分类名称集合</p>
        /// </summary>
        [JsonProperty("CategoryNames")]
        public string[] CategoryNames{ get; set; }

        /// <summary>
        /// <p>最高级别ID</p>
        /// </summary>
        [JsonProperty("LevelId")]
        public ulong? LevelId{ get; set; }

        /// <summary>
        /// <p>最高级别名称</p>
        /// </summary>
        [JsonProperty("LevelName")]
        public string LevelName{ get; set; }

        /// <summary>
        /// <p>级别敏感程度</p>
        /// </summary>
        [JsonProperty("LevelScore")]
        public ulong? LevelScore{ get; set; }

        /// <summary>
        /// <p>检出时间</p>
        /// </summary>
        [JsonProperty("DetectedTime")]
        public string DetectedTime{ get; set; }

        /// <summary>
        /// <p>分类详情</p>
        /// </summary>
        [JsonProperty("CategoryDetails")]
        public DspmIdentifyCategoryDetail[] CategoryDetails{ get; set; }

        /// <summary>
        /// <p>APPID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>账号名称</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>账号ID</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "DetectedDbCount", this.DetectedDbCount);
            this.SetParamSimple(map, prefix + "DetectedTableCount", this.DetectedTableCount);
            this.SetParamArraySimple(map, prefix + "RuleIds.", this.RuleIds);
            this.SetParamArraySimple(map, prefix + "RuleNames.", this.RuleNames);
            this.SetParamArraySimple(map, prefix + "CategoryIds.", this.CategoryIds);
            this.SetParamArraySimple(map, prefix + "CategoryNames.", this.CategoryNames);
            this.SetParamSimple(map, prefix + "LevelId", this.LevelId);
            this.SetParamSimple(map, prefix + "LevelName", this.LevelName);
            this.SetParamSimple(map, prefix + "LevelScore", this.LevelScore);
            this.SetParamSimple(map, prefix + "DetectedTime", this.DetectedTime);
            this.SetParamArrayObj(map, prefix + "CategoryDetails.", this.CategoryDetails);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
        }
    }
}

