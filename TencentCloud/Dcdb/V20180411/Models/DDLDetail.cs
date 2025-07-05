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

namespace TencentCloud.Dcdb.V20180411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DDLDetail : AbstractModel
    {
        
        /// <summary>
        /// 分片Id
        /// </summary>
        [JsonProperty("ShardSerialId")]
        public string ShardSerialId{ get; set; }

        /// <summary>
        /// 数据库
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 表
        /// </summary>
        [JsonProperty("Table")]
        public string Table{ get; set; }

        /// <summary>
        /// 执行的DDL任务内容
        /// </summary>
        [JsonProperty("Alter")]
        public string Alter{ get; set; }

        /// <summary>
        /// 开始执行时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 当前任务状态。0 成功； 1失败；  2进行中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 任务详细描述信息
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 任务当前所处阶段
        /// </summary>
        [JsonProperty("Stage")]
        public string Stage{ get; set; }

        /// <summary>
        /// 切换状态：1: 未到切换阶段；2：正在等待进行表切换；3: 正在进行切换；4: 切换成功；5: 切换失败
        /// </summary>
        [JsonProperty("SwitchStatus")]
        public long? SwitchStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShardSerialId", this.ShardSerialId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "Table", this.Table);
            this.SetParamSimple(map, prefix + "Alter", this.Alter);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamSimple(map, prefix + "Stage", this.Stage);
            this.SetParamSimple(map, prefix + "SwitchStatus", this.SwitchStatus);
        }
    }
}

