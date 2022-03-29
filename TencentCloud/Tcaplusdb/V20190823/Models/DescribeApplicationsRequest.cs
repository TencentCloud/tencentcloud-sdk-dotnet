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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApplicationsRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID，用于获取指定集群的单据
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 分页，限制当前返回多少条记录，大于等于10
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 分页，从多少条数据开始返回
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 申请单状态，用于过滤，0-待审核 1-已经审核并提交任务 2-已驳回
        /// </summary>
        [JsonProperty("CensorStatus")]
        public long? CensorStatus{ get; set; }

        /// <summary>
        /// 表格组id，用于过滤
        /// </summary>
        [JsonProperty("TableGroupId")]
        public string TableGroupId{ get; set; }

        /// <summary>
        /// 表格名，用于过滤
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 申请人uin，用于过滤
        /// </summary>
        [JsonProperty("Applicant")]
        public string Applicant{ get; set; }

        /// <summary>
        /// 申请类型，用于过滤，0加表 1删除表 2清理表 3修改表 4表重建 5存储层扩缩容 6接入层扩缩容 7复制表数据 8key回档
        /// </summary>
        [JsonProperty("ApplyType")]
        public long? ApplyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "CensorStatus", this.CensorStatus);
            this.SetParamSimple(map, prefix + "TableGroupId", this.TableGroupId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "Applicant", this.Applicant);
            this.SetParamSimple(map, prefix + "ApplyType", this.ApplyType);
        }
    }
}

