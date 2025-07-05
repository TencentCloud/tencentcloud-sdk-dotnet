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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaveCustomFunctionRequest : AbstractModel
    {
        
        /// <summary>
        /// 函数唯一标识
        /// </summary>
        [JsonProperty("FunctionId")]
        public string FunctionId{ get; set; }

        /// <summary>
        /// 分类：窗口函数、聚合函数、日期函数......
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// 集群引擎实例
        /// </summary>
        [JsonProperty("ClusterIdentifier")]
        public string ClusterIdentifier{ get; set; }

        /// <summary>
        /// 类名
        /// </summary>
        [JsonProperty("ClassName")]
        public string ClassName{ get; set; }

        /// <summary>
        /// 资源列表
        /// </summary>
        [JsonProperty("ResourceList")]
        public FunctionResource[] ResourceList{ get; set; }

        /// <summary>
        /// 函数说明
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 用法
        /// </summary>
        [JsonProperty("Usage")]
        public string Usage{ get; set; }

        /// <summary>
        /// 参数说明
        /// </summary>
        [JsonProperty("ParamDesc")]
        public string ParamDesc{ get; set; }

        /// <summary>
        /// 返回值说明
        /// </summary>
        [JsonProperty("ReturnDesc")]
        public string ReturnDesc{ get; set; }

        /// <summary>
        /// 示例
        /// </summary>
        [JsonProperty("Example")]
        public string Example{ get; set; }

        /// <summary>
        /// 项目id，不支持修改，dlc侧创建函数保存时用
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 数据库名称，不支持修改，dlc侧创建函数保存时用
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 函数名称，不支持修改，dlc侧创建函数保存时用
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionId", this.FunctionId);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "ClusterIdentifier", this.ClusterIdentifier);
            this.SetParamSimple(map, prefix + "ClassName", this.ClassName);
            this.SetParamArrayObj(map, prefix + "ResourceList.", this.ResourceList);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "ParamDesc", this.ParamDesc);
            this.SetParamSimple(map, prefix + "ReturnDesc", this.ReturnDesc);
            this.SetParamSimple(map, prefix + "Example", this.Example);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
        }
    }
}

