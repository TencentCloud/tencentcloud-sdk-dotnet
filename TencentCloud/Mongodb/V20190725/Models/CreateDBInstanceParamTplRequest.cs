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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDBInstanceParamTplRequest : AbstractModel
    {
        
        /// <summary>
        /// 参数模板名称。
        /// </summary>
        [JsonProperty("TplName")]
        public string TplName{ get; set; }

        /// <summary>
        /// 版本号，该参数模板支持的售卖版本请参照查询云数据库的售卖规格（DescribeSpecInfo）返回结果。参数与版本对应关系是：MONGO_36_WT：MongoDB 3.6 WiredTiger存储引擎版本，MONGO_40_WT：MongoDB 4.0 WiredTiger存储引擎版本，MONGO_42_WT：MongoDB 4.2 WiredTiger存储引擎版本。当MirrorTplId为空时，该字段必填。
        /// </summary>
        [JsonProperty("MongoVersion")]
        public string MongoVersion{ get; set; }

        /// <summary>
        /// 实例类型，REPLSET-副本集，SHARD-分片集群，STANDALONE-单节点
        /// 当MirrorTplId为空时，该字段必填。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 模板描述信息。
        /// </summary>
        [JsonProperty("TplDesc")]
        public string TplDesc{ get; set; }

        /// <summary>
        /// 模板参数，若为空，则以系统默认模板作为新版本参数。
        /// </summary>
        [JsonProperty("Params")]
        public ParamType[] Params{ get; set; }

        /// <summary>
        /// 镜像模板ID，若该字段不为空，则以该模板为镜像，克隆出一个新的模板。注意：MirrorTplId不为空时，MongoVersion及ClusterType将以MirrorTpl模板的版本及实例类型为准。
        /// </summary>
        [JsonProperty("MirrorTplId")]
        public string MirrorTplId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TplName", this.TplName);
            this.SetParamSimple(map, prefix + "MongoVersion", this.MongoVersion);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "TplDesc", this.TplDesc);
            this.SetParamArrayObj(map, prefix + "Params.", this.Params);
            this.SetParamSimple(map, prefix + "MirrorTplId", this.MirrorTplId);
        }
    }
}

