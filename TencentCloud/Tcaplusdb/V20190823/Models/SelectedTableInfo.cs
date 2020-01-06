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

    public class SelectedTableInfo : AbstractModel
    {
        
        /// <summary>
        /// 表所属大区ID
        /// </summary>
        [JsonProperty("LogicZoneId")]
        public string LogicZoneId{ get; set; }

        /// <summary>
        /// 表名称
        /// </summary>
        [JsonProperty("TableName")]
        public string TableName{ get; set; }

        /// <summary>
        /// 表实例ID
        /// </summary>
        [JsonProperty("TableInstanceId")]
        public string TableInstanceId{ get; set; }

        /// <summary>
        /// 表描述语言类型：`PROTO`或`TDR`
        /// </summary>
        [JsonProperty("TableIdlType")]
        public string TableIdlType{ get; set; }

        /// <summary>
        /// 表数据结构类型：`GENERIC`或`LIST`
        /// </summary>
        [JsonProperty("TableType")]
        public string TableType{ get; set; }

        /// <summary>
        /// LIST表元素个数
        /// </summary>
        [JsonProperty("ListElementNum")]
        public long? ListElementNum{ get; set; }

        /// <summary>
        /// 表预留容量（GB）
        /// </summary>
        [JsonProperty("ReservedVolume")]
        public long? ReservedVolume{ get; set; }

        /// <summary>
        /// 表预留读QPS
        /// </summary>
        [JsonProperty("ReservedReadQps")]
        public long? ReservedReadQps{ get; set; }

        /// <summary>
        /// 表预留写QPS
        /// </summary>
        [JsonProperty("ReservedWriteQps")]
        public long? ReservedWriteQps{ get; set; }

        /// <summary>
        /// 表备注信息
        /// </summary>
        [JsonProperty("Memo")]
        public string Memo{ get; set; }

        /// <summary>
        /// Key回档文件名，回档专用
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// Key回档文件扩展名，回档专用
        /// </summary>
        [JsonProperty("FileExtType")]
        public string FileExtType{ get; set; }

        /// <summary>
        /// Key回档文件大小，回档专用
        /// </summary>
        [JsonProperty("FileSize")]
        public long? FileSize{ get; set; }

        /// <summary>
        /// Key回档文件内容，回档专用
        /// </summary>
        [JsonProperty("FileContent")]
        public string FileContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogicZoneId", this.LogicZoneId);
            this.SetParamSimple(map, prefix + "TableName", this.TableName);
            this.SetParamSimple(map, prefix + "TableInstanceId", this.TableInstanceId);
            this.SetParamSimple(map, prefix + "TableIdlType", this.TableIdlType);
            this.SetParamSimple(map, prefix + "TableType", this.TableType);
            this.SetParamSimple(map, prefix + "ListElementNum", this.ListElementNum);
            this.SetParamSimple(map, prefix + "ReservedVolume", this.ReservedVolume);
            this.SetParamSimple(map, prefix + "ReservedReadQps", this.ReservedReadQps);
            this.SetParamSimple(map, prefix + "ReservedWriteQps", this.ReservedWriteQps);
            this.SetParamSimple(map, prefix + "Memo", this.Memo);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileExtType", this.FileExtType);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "FileContent", this.FileContent);
        }
    }
}

